using MOS;

namespace cs64
{
    class C64
    {
        public readonly RAMDevice Memory = new(new byte[1024 * 64]);
        public uint[] VideoBuffer;

        private byte PORT_DIRECTIONAL_DATA_REGISTER { get => Memory.Data[0]; set => Memory.Data[0] = value; }
        private byte PORT_REGISTER { get => Memory.Data[1]; set => Memory.Data[1] = value; }
        private bool LORAM => (PORT_REGISTER & 1) == 1;
        private bool HIRAM => (PORT_REGISTER & 2) == 2;
        private bool CHAREN => (PORT_REGISTER & 4) == 0;


        // Devices
        private readonly ROMDevice _kernal;
        private readonly ROMDevice _chargen;
        private readonly ROMDevice _basic;

        private readonly RAMDevice _vicMemory = new(new byte[0x400]);
        private readonly Fake6502 _cpu;
        public readonly CIA1 _cia1;

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
            PORT_REGISTER = 0x7;

            _cpu = new Fake6502(true, Read6502, Write6502);
            _cpu.Reset();

            _cia1 = new CIA1(_cpu.IssueIRQ);
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
            if (address >= 0xE000 && HIRAM)
            {
                return new AddressDecodeResult(false, _kernal, address - 0xE000);
            }
            else if (address >= 0xDC00 && address <= 0xDCFF)
            {
                // CIA1
                return new AddressDecodeResult(true, _cia1, address - 0xDC00);
            }
            else if (address >= 0xD000)
            {
                if (CHAREN)
                {
                    return new AddressDecodeResult(false, _chargen, address - 0xD000);
                }
                else if (address < 0xD400)
                {
                    return new AddressDecodeResult(true, _vicMemory, address - 0xD000);
                }
            }
            else if (address >= 0xA000 && address < 0xC000 && LORAM)
            {
                return new AddressDecodeResult(false, _basic, address - 0xA000);
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
                
        private void ExecTicks(uint tickcount)
        {
            var clockgoal6502 = _cpu.ClockTicks6502 + tickcount;

            while (_cpu.ClockTicks6502 < clockgoal6502)
            {
                _cpu.Step();
                _cia1.Step();
            }
        }

        public void RunFrame()
        {
            for (byte line = 0; line < 220; line++)
            {
                _vicMemory.Data[Vic2_CurrentRasterLine] = line;

                ExecTicks(64);

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
                        byte char_x = (byte)((x - 10) / 8);
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
}
