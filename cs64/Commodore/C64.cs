using MOS;
using MOS.OpenGL;

namespace cs64;

class C64
{
    public readonly RAMDevice Memory = new(new byte[1024 * 64]);
    public uint[] VideoBuffer;

    private byte PORT_DIRECTIONAL_DATA_REGISTER { set => Memory.Data[0] = value; }
    private byte PORT_REGISTER { get => Memory.Data[1]; set => Memory.Data[1] = value; }
    private bool LORAM => (PORT_REGISTER & 1) == 1;
    private bool HIRAM => (PORT_REGISTER & 2) == 2;
    private bool CHAREN => (PORT_REGISTER & 4) == 4;


    // Devices
    private readonly ROMDevice _kernal;
    private readonly ROMDevice _chargen;
    private readonly ROMDevice _basic;

    private readonly RAMDevice _vicMemory = new(new byte[0x400]);
    private readonly Fake6502 _cpu;
    public readonly CIA _cia1;

    private uint[] _palette = new uint[]{
            0x000000FFu,
            0xFFFFFFFFu,
            0x880000FFu,
            0xAAFFEEFFu,
            0xCC44CCFFu,
            0x00CC55FFu,
            0x0000AAFFu,
            0xEEEE77FFu,
            0xDD8855FFu,
            0x664400FFu,
            0xFF7777FFu,
            0x333333FFu,
            0x777777FFu,
            0xAAFF66FFu,
            0x0088FFFFu,
            0xBBBBBBFFu
        };
    private readonly Random _random = new Random();
    private readonly FramebufferForm _framebufferForm;

    public C64(FramebufferForm framebufferForm)
    {
        _kernal = new ROMDevice(File.ReadAllBytes("Roms/kernal"));
        _basic = new ROMDevice(File.ReadAllBytes("Roms/basic"));
        _chargen = new ROMDevice(File.ReadAllBytes("Roms/chargen"));

        VideoBuffer = new uint[340 * 220];

        _random.NextBytes(Memory.Data);

        PORT_DIRECTIONAL_DATA_REGISTER = 0x2F;
        PORT_REGISTER = 0x37;

        _cpu = new Fake6502(true, Read6502, Write6502);
        _cpu.Reset();

        _cia1 = new CIA(_cpu.IssueIRQ, ReadCIA1, WriteCIA1);
        _framebufferForm = framebufferForm;
    }

    Keys[] _keyboardmap = new Keys[]
    {
        Keys.Delete, Keys.Return, Keys.Left, Keys.F7, Keys.F1, Keys.F3, Keys.F5, Keys.Up,
        Keys.D3, Keys.W, Keys.A, Keys.D4, Keys.Z, Keys.S, Keys.E, Keys.ShiftKey,
        Keys.D5, Keys.R, Keys.D, Keys.D6, Keys.C, Keys.F, Keys.T, Keys.X,
        Keys.D7, Keys.Y, Keys.G, Keys.D8, Keys.B, Keys.H, Keys.U, Keys.V,
        Keys.D9, Keys.I, Keys.J, Keys.D0, Keys.M, Keys.K, Keys.O, Keys.N,
        Keys.Oemplus, Keys.P, Keys.L, Keys.OemMinus, Keys.OemPeriod, Keys.OemPipe, Keys.Oemtilde, Keys.Oemcomma,
        Keys.NumPad0, Keys.NumPad1, Keys.OemSemicolon, Keys.Home, Keys.ShiftKey, Keys.NumPad3, Keys.NumPad8, Keys.OemBackslash,
        Keys.D1, Keys.Back, Keys.Control, Keys.D2, Keys.Space, Keys.Alt, Keys.Q, Keys.Tab
    };

    byte keyboardRowMask = 0;

    byte ReadCIA1(CIA.Port port)
    {
        if (port == CIA.Port.A)
            return keyboardRowMask;

        // Write to Port A = Strobe columns (inverted)
        // Read from Port B = Mask rows

        byte result = 0;
        for(var row = 0; row < 8; row++)
        {
            if (((keyboardRowMask >> row) & 1) == 1)
                continue;

            for(var col = 0; col < 8; col++)
            {
                var currentKeyIndex = row * 8 + col;
                var currentKey = _keyboardmap[currentKeyIndex];
                if (_framebufferForm.IsKeyDown(currentKey))
                {
                    result |= (byte)(1 << col);
                }
            }
        }

        return (byte)~result;
    }

    void WriteCIA1(CIA.Port port, byte value)
    {
        if (port == CIA.Port.A)
        {
            keyboardRowMask = value;
        }
    }

    private struct AddressDecodeResult
    {
        public bool CanWrite;
        public IDevice Device;
        public ushort Offset;

        public AddressDecodeResult(bool canWrite, IDevice device, int offset)
        {
            CanWrite = canWrite;
            Device = device;
            Offset = (ushort)offset;
        }
    }

    private AddressDecodeResult DecodeAddress(ushort address)
    {
        var charRomEnabled = !CHAREN && (HIRAM || LORAM);
        var ioEnabled = CHAREN && (HIRAM || LORAM);
        var basicEnabled = HIRAM && LORAM;
        var kernalEnabled = HIRAM;

        if (kernalEnabled && address >= 0xE000 && address <= 0xFFFF)
        {
            return new AddressDecodeResult(false, _kernal, address - 0xE000);
        }
        else if (basicEnabled && address >= 0xA000 && address <= 0xBFFF)
        {
            return new AddressDecodeResult(false, _basic, address - 0xA000);
        }
        else if (address >= 0xD000 && address <= 0xDFFF)
        {
            if (charRomEnabled)
            {
                return new AddressDecodeResult(false, _chargen, address - 0xD000);
            }
            else if (ioEnabled)
            {
                if (address >= 0xD000 && address <= 0xD02E)
                {
                    return new AddressDecodeResult(true, _vicMemory, address - 0xD000);
                }
                else if (address >= 0xDC00 && address <= 0xDCFF)
                {
                    return new AddressDecodeResult(true, _cia1, address & 0x0F);
                }
                //else if(address >= 0xDD00 && address <= 0xDDFF)
                //{
                //    // CIA2
                //}
            }
        }

        return new AddressDecodeResult(true, Memory, address);
    }

    private byte Read6502(ushort address)
    {
        var result = DecodeAddress(address);
        return result.Device.Read(result.Offset);
    }

    private void Write6502(ushort address, byte value)
    {
        var result = DecodeAddress(address);
        if (result.CanWrite)
            result.Device.Write(result.Offset, value);
    }

    const ushort Vic2_BaseAddress = 0xD000;
    const ushort Vic2_CurrentRasterLine = 0xD012 - Vic2_BaseAddress;
    const ushort Vic2_BorderColor = 0xD020 - Vic2_BaseAddress;
    const ushort Vic2_BackgroundColor = 0xD021 - Vic2_BaseAddress;
    const ushort Vic2_ScreenControlRegister1 = 0xD011 - Vic2_BaseAddress;
    const ushort Vic2_ScreenControlRegister2 = 0xD016 - Vic2_BaseAddress;

    const ushort ColorRam_BaseAddress = 0xD800;

    List<ushort> _breakpoints = new()
    {
        //0xEA31, // IRQ Vector
        //0xF69B,  // Update time
        //0xFF48,
        //0xEA98 // Check keyboard
    };

    private void ExecTicks(uint clockgoal6502)
    {
        _cpu.ClockTicks6502 = 0;
        for(var i = 0; i < clockgoal6502; i++)
        {
            if (_breakpoints.Any(x => x == _cpu.PC))
            {
                Console.WriteLine($".,{_cpu.PC.ToHex()}\tA: ${_cpu.A.ToHex()}\tX: ${_cpu.X.ToHex()}\tY: ${_cpu.Y.ToHex()}");
                Console.WriteLine($"SP: ${_cpu.SP.ToHex()}");
                var d = $"{Disassembler.DisassembleNext(Read6502, _cpu.PC).Item1}";
                Console.WriteLine(d);
                Console.WriteLine();
                Console.ReadLine();
            }
            if (_cpu.ClockTicks6502 <= clockgoal6502)
            {
                //Console.WriteLine($".,{_cpu.PC.ToHex()}\tA: ${_cpu.A.ToHex()}\tX: ${_cpu.X.ToHex()}\tY: ${_cpu.Y.ToHex()}");
                _cpu.Step();
            }

            _cia1.Step();
        }
    }

    public void RunFrame()
    {
        for (var line = 0; line < 312; line++)
        {
            _vicMemory.Data[Vic2_CurrentRasterLine] = (byte)line;
            _cpu.ClockTicks6502 = 0;
            ExecTicks(63);
        }
    }

    public void DrawFrame()
    {
        for (byte line = 0; line < 220; line++)
        {
            byte borderColor = _vicMemory.Data[Vic2_BorderColor];
            byte bgColor = _vicMemory.Data[Vic2_BackgroundColor];

            byte h_scroll = _vicMemory.Data[Vic2_ScreenControlRegister2 & 7];
            byte v_scroll = _vicMemory.Data[Vic2_ScreenControlRegister1 & 7];

            byte char_y = (byte)((line - 10 - v_scroll) / 8);
            byte char_offset_y = (byte)((line - 10 - v_scroll) % 8);

            for (var x = 0; x < 340; x++)
            {
                byte color;
                if (x < 10 || x > 329 || (line - v_scroll) < 10 || ((line - v_scroll) % 220) > 209)
                    color = borderColor;
                else
                {
                    byte char_x = (byte)((x - 10) >> 3);
                    byte char_offset_x = (byte)((x - 10) % 8);

                    byte chr = Memory.Data[0x400 + (char_y * 40) + char_x];
                    byte chr_fnt = _chargen.Data[(chr * 8) + char_offset_y];

                    bool on = ((chr_fnt << char_offset_x) & 0x80) != 0;
                    color = on ? Memory.Data[ColorRam_BaseAddress + (char_y * 40) + char_x] : bgColor;
                }

                VideoBuffer[line * 340 + ((x + h_scroll) % 340)] = _palette[color % 16];
            }
        }
    }
}

public static class HexExtensions
{
    public static string ToHex(this ushort v) => v.ToString("X").PadLeft(4, '0');
    public static string ToHex(this byte v) => v.ToString("X").PadLeft(2, '0');
}