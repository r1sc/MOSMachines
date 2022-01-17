namespace MOS;

public static class Disassembler
{
    public static (string, ushort) DisassembleNext(Func<ushort, byte> read6502, ushort pc)
    {
        var opcode = read6502(pc++);
        var aaa = opcode >> 5;
        var bbb = (opcode >> 2) & 7;
        var cc = opcode & 3;

        var read8 = () => "$" + read6502(pc++).ToString("X").PadLeft(2, '0');
        var read16 = () =>
        {
            var lo = read6502(pc++);
            var hi = read6502(pc++);
            return "$" + ((hi << 8) | lo).ToString("X").PadLeft(4, '0');
        };

        var linedata = new List<string>();
        var zeropage_x = () => linedata.Add($"{ read8()},X)");
        var zeropage = () => linedata.Add($"{ read8()}");
        var immediate = () => linedata.Add($"#{read8()}");
        var absolute = () => linedata.Add($"{ read16()}");
        var indirect = () => linedata.Add($"({ read16()})");
        var zeropage_y = () => linedata.Add($"({ read8()}),Y");
        var zeropage_x2 = () => linedata.Add($"{ read8()},X");
        var absolute_y = () => linedata.Add($"{ read16()},Y");
        var absolute_x = () => linedata.Add($"{ read16()},X");
        var accumulator = () => linedata.Add("A");
        var relative = () =>
        {
            var d = (int)read6502(pc++);
            if ((d & 0x80) == 0x80)
                d = -(d ^ 0xFF);
            linedata.Add($"{ d}");
        };

        switch (opcode)
        {
            case 0x00: linedata.Add("BRK"); break;
            case 0x08: linedata.Add("PHP"); break;
            case 0x10: linedata.Add("BPL"); relative(); break;
            case 0x18: linedata.Add("CLC"); break;
            case 0x20: linedata.Add("JSR"); absolute(); break;
            case 0x28: linedata.Add("PLP"); break;
            case 0x30: linedata.Add("BMI"); relative(); break;
            case 0x38: linedata.Add("SEC"); break;
            case 0x40: linedata.Add("RTI"); break;
            case 0x48: linedata.Add("PHA"); break;
            case 0x50: linedata.Add("BVC"); relative(); break;
            case 0x58: linedata.Add("CLI"); break;
            case 0x60: linedata.Add("RTS"); break;
            case 0x68: linedata.Add("PLA"); break;
            case 0x70: linedata.Add("BVS"); relative(); break;
            case 0x78: linedata.Add("SEI"); break;
            case 0x88: linedata.Add("DEY"); break;
            case 0x8A: linedata.Add("TXA"); break;
            case 0x90: linedata.Add("BCC"); relative(); break;
            case 0x9A: linedata.Add("TXS"); break;
            case 0x98: linedata.Add("TYA"); break;
            case 0xA8: linedata.Add("TAY"); break;
            case 0xAA: linedata.Add("TAX"); break;
            case 0xB0: linedata.Add("BCS"); relative(); break;
            case 0xB8: linedata.Add("CLV"); break;
            case 0xBA: linedata.Add("TSX"); break;
            case 0xC8: linedata.Add("INY"); break;
            case 0xCA: linedata.Add("DEX"); break;
            case 0xD0: linedata.Add("BNE"); relative(); break;
            case 0xD8: linedata.Add("CLD"); break;
            case 0xE8: linedata.Add("INX"); break;
            case 0xEA: linedata.Add("NOP"); break;
            case 0xF0: linedata.Add("BEQ"); relative(); break;
            case 0xF8: linedata.Add("SED"); break;
            default:
                switch (cc)
                {
                    case 1:
                        {
                            switch (aaa)
                            {
                                case 0: linedata.Add("ORA"); break;
                                case 1: linedata.Add("AND"); break;
                                case 2: linedata.Add("EOR"); break;
                                case 3: linedata.Add("ADC"); break;
                                case 4: linedata.Add("STA"); break;
                                case 5: linedata.Add("LDA"); break;
                                case 6: linedata.Add("CMP"); break;
                                case 7: linedata.Add("SBC"); break;
                            }
                            switch (bbb)
                            {
                                case 0: zeropage_x(); break;
                                case 1: zeropage(); break;
                                case 2: immediate(); break;
                                case 3: absolute(); break;
                                case 4: zeropage_y(); break;
                                case 5: zeropage_x2(); break;
                                case 6: absolute_y(); break;
                                case 7: absolute_x(); break;
                            }
                            break;
                        }
                    case 2:
                        {
                            switch (aaa)
                            {
                                case 0: linedata.Add("ASL"); break;
                                case 1: linedata.Add("ROL"); break;
                                case 2: linedata.Add("LSR"); break;
                                case 3: linedata.Add("ROR"); break;
                                case 4: linedata.Add("STX"); break;
                                case 5: linedata.Add("LDX"); break;
                                case 6: linedata.Add("DEC"); break;
                                case 7: linedata.Add("INC"); break;
                            }
                            switch (bbb)
                            {
                                case 0: immediate(); break;
                                case 1: zeropage(); break;
                                case 2: accumulator(); break;
                                case 3: absolute(); break;
                                case 5: if (aaa == 4 || aaa == 5) zeropage_y(); else zeropage_x2(); break;
                                case 7: if (aaa == 5) absolute_y(); else absolute_x(); break;
                            }
                            break;
                        }
                    case 0:
                        {
                            switch (aaa)
                            {
                                case 1: linedata.Add("BIT"); break;
                                case 2: linedata.Add("JMP"); break;
                                case 3: linedata.Add("JMP"); break;
                                case 4: linedata.Add("STY"); break;
                                case 5: linedata.Add("LDY"); break;
                                case 6: linedata.Add("CPY"); break;
                                case 7: linedata.Add("CPX"); break;
                            }
                            switch (bbb)
                            {
                                case 0: immediate(); break;
                                case 1: zeropage(); break;
                                case 3: if (aaa == 3) indirect(); else absolute(); break;
                                case 5: zeropage_x2(); break;
                                case 7: absolute_x(); break;
                            }
                            break;
                        }
                }
                break;
        }

        return (string.Join(' ', linedata), pc);
    }
}