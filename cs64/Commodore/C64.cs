using MOS;

namespace cs64;

class C64
{
    public readonly RAMDevice Memory = new(new byte[1024 * 64]);
    public uint[] VideoBuffer;

    private byte PORT_DIRECTIONAL_DATA_REGISTER { get => Memory.Data[0]; set => Memory.Data[0] = value; }
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

    public C64()
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
    }

    byte ReadCIA1(CIA.Port port)
    {
        return 0;
    }

    void WriteCIA1(CIA.Port port, byte value)
    {

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
        //0xFF48
    };

    private void ExecTicks(uint clockgoal6502)
    {
        _cpu.ClockTicks6502 = 0;
        for(var i = 0; i < clockgoal6502; i++)
        {
            //if(_breakpoints.Any(x => x == _cpu.PC))
            //{
            //    Console.WriteLine($".,{_cpu.PC.ToHex()}\tA: ${_cpu.A.ToHex()}\tX: ${_cpu.X.ToHex()}\tY: ${_cpu.Y.ToHex()}");
            //    Console.WriteLine($"SP: ${_cpu.SP.ToHex()}");
            //    var d = $"{Disassembler.DisassembleNext(Read6502, _cpu.PC).Item1}";
            //    Console.WriteLine(d);
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}
            if(_cpu.ClockTicks6502 <= clockgoal6502)
                _cpu.Step();

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