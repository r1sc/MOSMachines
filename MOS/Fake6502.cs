namespace MOS;
public class Fake6502
{

    /* Fake6502 CPU emulator core v1.1 *******************
     * (c)2011 Mike Chambers (miker00lz@gmail.com)       *
     *****************************************************
     * v1.1 - Small bugfix in BIT opcode, but it was the *
     *        difference between a few games in my NES   *
     *        emulator working and being broken!         *
     *        I went through the rest carefully again    *
     *        after fixing it just to make sure I didn't *
     *        have any other typos! (Dec. 17, 2011)      *
     *                                                   *
     * v1.0 - First release (Nov. 24, 2011)              *
     *****************************************************
     * LICENSE: This source code is released into the    *
     * public domain, but if you use it please do give   *
     * credit. I put a lot of effort into writing this!  *
     *                                                   *
     *****************************************************
     * Fake6502 is a MOS Technology 6502 CPU emulation   *
     * engine in C. It was written as part of a Nintendo *
     * Entertainment System emulator I've been writing.  *
     *                                                   *
     * A couple important things to know about are two   *
     * defines in the code. One is "UNDOCUMENTED" which, *
     * when defined, allows Fake6502 to compile with     *
     * full support for the more predictable             *
     * undocumented instructions of the 6502. If it is   *
     * undefined, undocumented opcodes just act as NOPs. *
     *                                                   *
     * The other define is "NES_CPU", which causes the   *
     * code to compile without support for binary-coded  *
     * decimal (BCD) support for the ADC and SBC         *
     * opcodes. The Ricoh 2A03 CPU in the NES does not   *
     * support BCD, but is otherwise identical to the    *
     * standard MOS 6502. (Note that this define is      *
     * enabled in this file if you haven't changed it    *
     * yourself. If you're not emulating a NES, you      *
     * should comment it out.)                           *
     *                                                   *
     * If you do discover an error in timing accuracy,   *
     * or operation in general please e-mail me at the   *
     * address above so that I can fix it. Thank you!    *
     *                                                   *
     *****************************************************
     * Usage:                                            *
     *                                                   *
     * Fake6502 requires you to provide two external     *
     * functions:                                        *
     *                                                   *
     * byte read6502(UInt16 address)                *
     * void write6502(UInt16 address, byte value)   *
     *                                                   *
     * You may optionally pass Fake6502 the pointer to a *
     * function which you want to be called after every  *
     * emulated instruction. This function should be a   *
     * void with no parameters expected to be passed to  *
     * it.                                               *
     *                                                   *
     * This can be very useful. For example, in a NES    *
     * emulator, you check the number of clock ticks     *
     * that have passed so you can know when to handle   *
     * APU events.                                       *
     *                                                   *
     * To pass Fake6502 this pointer, use the            *
     * hookexternal(void *funcptr) function provided.    *
     *                                                   *
     * To disable the hook later, pass NULL to it.       *
     *****************************************************
     * Useful functions in this emulator:                *
     *                                                   *
     * void reset6502()                                  *
     *   - Call this once before you begin execution.    *
     *                                                   *
     * void exec6502(UInt32 tickcount)                 *
     *   - Execute 6502 code up to the next specified    *
     *     count of clock ticks.                         *
     *                                                   *
     * void step6502()                                   *
     *   - Execute a single instrution.                  *
     *                                                   *
     * void irq6502()                                    *
     *   - Trigger a hardware IRQ in the 6502 core.      *
     *                                                   *
     * void nmi6502()                                    *
     *   - Trigger an NMI in the 6502 core.              *
     *                                                   *
     * void hookexternal(void *funcptr)                  *
     *   - Pass a pointer to a void function taking no   *
     *     parameters. This will cause Fake6502 to call  *
     *     that function once after each emulated        *
     *     instruction.                                  *
     *                                                   *
     *****************************************************
     * Useful variables in this emulator:                *
     *                                                   *
     * UInt32 clockticks6502                           *
     *   - A running total of the emulated cycle count.  *
     *                                                   *
     * UInt32 instructions                             *
     *   - A running total of the total emulated         *
     *     instruction count. This is not related to     *
     *     clock cycle timing.                           *
     *                                                   *
     *****************************************************/

    private readonly Action[] addrtable;
    private readonly Action[] optable;
    private readonly bool _allowDecimalMode;

    //externally supplied functions
    public Func<ushort, byte> _read6502;
    public Action<ushort, byte> _write6502;

    public Fake6502(bool allowDecimalMode, Func<ushort, byte> read6502, Action<ushort, byte> write6502)
    {
        _allowDecimalMode = allowDecimalMode;
        addrtable = new Action[]{
            /*        |  0  |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  A  |  B  |  C  |  D  |  E  |  F  |     */
            /* 0 */     imp, indx,  imp, indx,   zp,   zp,   zp,   zp,  imp,  imm,  acc,  imm, abso, abso, abso, abso, /* 0 */
            /* 1 */     rel, indy,  imp, indy,  zpx,  zpx,  zpx,  zpx,  imp, absy,  imp, absy, absx, absx, absx, absx, /* 1 */
            /* 2 */    abso, indx,  imp, indx,   zp,   zp,   zp,   zp,  imp,  imm,  acc,  imm, abso, abso, abso, abso, /* 2 */
            /* 3 */     rel, indy,  imp, indy,  zpx,  zpx,  zpx,  zpx,  imp, absy,  imp, absy, absx, absx, absx, absx, /* 3 */
            /* 4 */     imp, indx,  imp, indx,   zp,   zp,   zp,   zp,  imp,  imm,  acc,  imm, abso, abso, abso, abso, /* 4 */
            /* 5 */     rel, indy,  imp, indy,  zpx,  zpx,  zpx,  zpx,  imp, absy,  imp, absy, absx, absx, absx, absx, /* 5 */
            /* 6 */     imp, indx,  imp, indx,   zp,   zp,   zp,   zp,  imp,  imm,  acc,  imm,  ind, abso, abso, abso, /* 6 */
            /* 7 */     rel, indy,  imp, indy,  zpx,  zpx,  zpx,  zpx,  imp, absy,  imp, absy, absx, absx, absx, absx, /* 7 */
            /* 8 */     imm, indx,  imm, indx,   zp,   zp,   zp,   zp,  imp,  imm,  imp,  imm, abso, abso, abso, abso, /* 8 */
            /* 9 */     rel, indy,  imp, indy,  zpx,  zpx,  zpy,  zpy,  imp, absy,  imp, absy, absx, absx, absy, absy, /* 9 */
            /* A */     imm, indx,  imm, indx,   zp,   zp,   zp,   zp,  imp,  imm,  imp,  imm, abso, abso, abso, abso, /* A */
            /* B */     rel, indy,  imp, indy,  zpx,  zpx,  zpy,  zpy,  imp, absy,  imp, absy, absx, absx, absy, absy, /* B */
            /* C */     imm, indx,  imm, indx,   zp,   zp,   zp,   zp,  imp,  imm,  imp,  imm, abso, abso, abso, abso, /* C */
            /* D */     rel, indy,  imp, indy,  zpx,  zpx,  zpx,  zpx,  imp, absy,  imp, absy, absx, absx, absx, absx, /* D */
            /* E */     imm, indx,  imm, indx,   zp,   zp,   zp,   zp,  imp,  imm,  imp,  imm, abso, abso, abso, abso, /* E */
            /* F */     rel, indy,  imp, indy,  zpx,  zpx,  zpx,  zpx,  imp, absy,  imp, absy, absx, absx, absx, absx  /* F */
            };

        optable = new Action[] {
            /*        |  0  |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  A  |  B  |  C  |  D  |  E  |  F  |      */
            /* 0 */      brk,  ora,  nop,  slo,  nop,  ora,  asl,  slo,  php,  ora,  asl,  nop,  nop,  ora,  asl,  slo, /* 0 */
            /* 1 */      bpl,  ora,  nop,  slo,  nop,  ora,  asl,  slo,  clc,  ora,  nop,  slo,  nop,  ora,  asl,  slo, /* 1 */
            /* 2 */      jsr,and,  nop,  rla,  bit,and,  rol,  rla,  plp,and,  rol,  nop,  bit,and,  rol,  rla, /* 2 */
            /* 3 */      bmi,and,  nop,  rla,  nop,and,  rol,  rla,  sec,and,  nop,  rla,  nop,and,  rol,  rla, /* 3 */
            /* 4 */      rti,  eor,  nop,  sre,  nop,  eor,  lsr,  sre,  pha,  eor,  lsr,  nop,  jmp,  eor,  lsr,  sre, /* 4 */
            /* 5 */      bvc,  eor,  nop,  sre,  nop,  eor,  lsr,  sre,  cli,  eor,  nop,  sre,  nop,  eor,  lsr,  sre, /* 5 */
            /* 6 */      rts,  adc,  nop,  rra,  nop,  adc,  ror,  rra,  pla,  adc,  ror,  nop,  jmp,  adc,  ror,  rra, /* 6 */
            /* 7 */      bvs,  adc,  nop,  rra,  nop,  adc,  ror,  rra,  sei,  adc,  nop,  rra,  nop,  adc,  ror,  rra, /* 7 */
            /* 8 */      nop,  sta,  nop,  sax,  sty,  sta,  stx,  sax,  dey,  nop,  txa,  nop,  sty,  sta,  stx,  sax, /* 8 */
            /* 9 */      bcc,  sta,  nop,  nop,  sty,  sta,  stx,  sax,  tya,  sta,  txs,  nop,  nop,  sta,  nop,  nop, /* 9 */
            /* A */      ldy,  lda,  ldx,  lax,  ldy,  lda,  ldx,  lax,  tay,  lda,  tax,  nop,  ldy,  lda,  ldx,  lax, /* A */
            /* B */      bcs,  lda,  nop,  lax,  ldy,  lda,  ldx,  lax,  clv,  lda,  tsx,  lax,  ldy,  lda,  ldx,  lax, /* B */
            /* C */      cpy,  cmp,  nop,  dcp,  cpy,  cmp,  dec,  dcp,  iny,  cmp,  dex,  nop,  cpy,  cmp,  dec,  dcp, /* C */
            /* D */      bne,  cmp,  nop,  dcp,  nop,  cmp,  dec,  dcp,  cld,  cmp,  nop,  dcp,  nop,  cmp,  dec,  dcp, /* D */
            /* E */      cpx,  sbc,  nop,  isb,  cpx,  sbc,  inc,  isb,  inx,  sbc,  nop,  sbc,  cpx,  sbc,  inc,  isb, /* E */
            /* F */      beq,  sbc,  nop,  isb,  nop,  sbc,  inc,  isb,  sed,  sbc,  nop,  isb,  nop,  sbc,  inc,  isb  /* F */
            };
        _read6502 = read6502;
        _write6502 = write6502;
    }

    //6502 defines

    private const byte FLAG_CARRY = 0x01;
    private const byte FLAG_ZERO = 0x02;
    private const byte FLAG_INTERRUPT_DISABLE = 0x04;
    private const byte FLAG_DECIMAL = 0x08;
    private const byte FLAG_BREAK = 0x10;
    private const byte FLAG_OVERFLOW = 0x40;
    private const byte FLAG_SIGN = 0x80;
    private const ushort BASE_STACK = 0x100;

    //6502 CPU registers
    public ushort PC;
    public byte SP, A, X, Y, STATUS;


    //helper variables
    public uint InstructionCount = 0; //keep track of total instructions executed
    public uint ClockTicks6502 = 0;
    private ushort oldpc, ea, reladdr, value, result;
    private byte opcode;

    //flag modifier macros
    private void saveaccum(ushort n)
    {
        A = (byte)((n) & 0x00FF);
    }

    private void setcarry() => STATUS |= FLAG_CARRY;
    private void clearcarry() => STATUS &= unchecked((byte)~FLAG_CARRY);
    private void setzero() => STATUS |= FLAG_ZERO;
    private void clearzero() => STATUS &= unchecked((byte)~FLAG_ZERO);
    private void setinterruptdisable() => STATUS |= FLAG_INTERRUPT_DISABLE;
    private void clearinterruptdisable() => STATUS &= unchecked((byte)~FLAG_INTERRUPT_DISABLE);
    private void setdecimal() => STATUS |= FLAG_DECIMAL;
    private void cleardecimal() => STATUS &= unchecked((byte)~FLAG_DECIMAL);
    private void setoverflow() => STATUS |= FLAG_OVERFLOW;
    private void clearoverflow() => STATUS &= unchecked((byte)~FLAG_OVERFLOW);
    private void setsign() => STATUS |= FLAG_SIGN;
    private void clearsign() => STATUS &= unchecked((byte)~FLAG_SIGN);


    //flag calculation macros
    private void zerocalc(ushort n)
    {
        if ((n & 0x00FF) != 0)
            clearzero();
        else
            setzero();
    }

    private void signcalc(ushort n)
    {
        if ((n & 0x0080) != 0)
            setsign();
        else
            clearsign();
    }

    private void carrycalc(ushort n)
    {
        if ((n & 0xFF00) != 0)
            setcarry();
        else
            clearcarry();
    }

    private void overflowcalc(ushort n, byte m, ushort o)
    { /* n = result, m = accumulator, o = memory */
        if (((n ^ m) & (n ^ o) & 0x0080) != 0)
            setoverflow();
        else
            clearoverflow();
    }


    //a few general functions used by various other functions
    private void push16(ushort pushval)
    {
        _write6502((ushort)(BASE_STACK + SP), (byte)((pushval >> 8) & 0xFF));
        _write6502((ushort)(BASE_STACK + ((SP - 1) & 0xFF)), (byte)(pushval & 0xFF));
        SP -= 2;
    }

    private void push8(byte pushval)
    {
        _write6502((ushort)(BASE_STACK + SP--), pushval);
    }

    private ushort pull16()
    {
        ushort temp16;
        temp16 = (ushort)(_read6502((ushort)(BASE_STACK + ((SP + 1) & 0xFF))) | (_read6502((ushort)(BASE_STACK + ((SP + 2) & 0xFF))) << 8));
        SP += 2;
        return (temp16);
    }

    private byte pull8()
    {
        return _read6502((ushort)(BASE_STACK + ++SP));
    }

    public void Reset()
    {
        PC = (ushort)(_read6502(0xFFFC) | (_read6502(0xFFFD) << 8));
        A = 0;
        X = 0;
        Y = 0;
        SP = 0xFD;
    }

    private byte penaltyop, penaltyaddr;

    //addressing mode functions, calculates effective addresses
    private void imp()
    { //implied
    }

    private void acc()
    { //accumulator
    }

    private void imm()
    { //immediate
        ea = PC++;
    }

    private void zp()
    { //zero-page
        ea = _read6502(PC++);
    }

    private void zpx()
    { //zero-page,X
        ea = (byte)(_read6502(PC++) + X); //zero-page wraparound
    }

    private void zpy()
    { //zero-page,Y
        ea = (byte)(_read6502(PC++) + Y); //zero-page wraparound
    }

    private void rel()
    { //relative for branch ops (8-bit immediate value, sign-extended)
        reladdr = _read6502(PC++);
        if ((reladdr & 0x80) != 0)
            reladdr |= 0xFF00;
    }

    private void abso()
    { //absolute
        ea = (ushort)(_read6502(PC) | (_read6502((ushort)(PC + 1)) << 8));
        PC += 2;
    }

    private void absx()
    { //absolute,X
        ushort startpage;
        ea = (ushort)(_read6502(PC) | (_read6502((ushort)(PC + 1)) << 8));
        startpage = (ushort)(ea & 0xFF00);
        ea += X;

        if (startpage != (ea & 0xFF00))
        { //one cycle penlty for page-crossing on some opcodes
            penaltyaddr = 1;
        }

        PC += 2;
    }

    private void absy()
    { //absolute,Y
        ushort startpage;
        ea = (ushort)(_read6502(PC) | (_read6502((ushort)(PC + 1)) << 8));
        startpage = (ushort)(ea & 0xFF00);
        ea += Y;

        if (startpage != (ea & 0xFF00))
        { //one cycle penlty for page-crossing on some opcodes
            penaltyaddr = 1;
        }

        PC += 2;
    }

    private void ind()
    { //indirect
        ushort eahelp, eahelp2;
        eahelp = (ushort)(_read6502(PC) | (ushort)(_read6502((ushort)(PC + 1)) << 8));
        eahelp2 = (ushort)((eahelp & 0xFF00) | ((eahelp + 1) & 0x00FF)); //replicate 6502 page-boundary wraparound bug
        ea = (ushort)(_read6502(eahelp) | (_read6502(eahelp2) << 8));
        PC += 2;
    }

    private void indx()
    { // (indirect,X)
        ushort eahelp;
        eahelp = (ushort)((_read6502(PC++) + X) & 0xFF); //zero-page wraparound for table pointer
        ea = (ushort)(_read6502((ushort)(eahelp & 0x00FF)) | (_read6502((ushort)((eahelp + 1) & 0x00FF)) << 8));
    }

    private void indy()
    { // (indirect),Y
        ushort eahelp, eahelp2, startpage;
        eahelp = _read6502(PC++);
        eahelp2 = (ushort)((eahelp & 0xFF00) | ((eahelp + 1) & 0x00FF)); //zero-page wraparound
        ea = (ushort)(_read6502(eahelp) | (_read6502(eahelp2) << 8));
        startpage = (ushort)(ea & 0xFF00);
        ea += Y;

        if (startpage != (ea & 0xFF00))
        { //one cycle penlty for page-crossing on some opcodes
            penaltyaddr = 1;
        }
    }

    private ushort getvalue()
    {
        if (addrtable[opcode] == acc) return A;
        else return _read6502(ea);
    }

    private ushort getvalue16()
    {
        return (ushort)(_read6502(ea) | (_read6502((ushort)(ea + 1)) << 8));
    }

    private void putvalue(ushort saveval)
    {
        if (addrtable[opcode] == acc) A = (byte)(saveval & 0x00FF);
        else _write6502(ea, (byte)(saveval & 0x00FF));
    }


    //instruction handler functions
    private void adc()
    {
        penaltyop = 1;
        value = getvalue();
        result = (ushort)(A + value + (ushort)(STATUS & FLAG_CARRY));

        carrycalc(result);
        zerocalc(result);
        overflowcalc(result, A, value);
        signcalc(result);

        if (_allowDecimalMode && (STATUS & FLAG_DECIMAL) != 0)
        {
            clearcarry();

            if ((A & 0x0F) > 0x09)
            {
                A += 0x06;
            }
            if ((A & 0xF0) > 0x90)
            {
                A += 0x60;
                setcarry();
            }

            ClockTicks6502++;
        }

        saveaccum(result);
    }

    private void and()
    {
        penaltyop = 1;
        value = getvalue();
        result = (ushort)(A & value);

        zerocalc(result);
        signcalc(result);

        saveaccum(result);
    }

    private void asl()
    {
        value = getvalue();
        result = (ushort)(value << 1);

        carrycalc(result);
        zerocalc(result);
        signcalc(result);

        putvalue(result);
    }

    private void bcc()
    {
        if ((STATUS & FLAG_CARRY) == 0)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void bcs()
    {
        if ((STATUS & FLAG_CARRY) == FLAG_CARRY)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void beq()
    {
        if ((STATUS & FLAG_ZERO) == FLAG_ZERO)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void bit()
    {
        value = getvalue();
        result = (ushort)(A & value);

        zerocalc(result);
        STATUS = (byte)((STATUS & 0x3F) | (byte)(value & 0xC0));
    }

    private void bmi()
    {
        if ((STATUS & FLAG_SIGN) == FLAG_SIGN)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void bne()
    {
        if ((STATUS & FLAG_ZERO) == 0)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void bpl()
    {
        if ((STATUS & FLAG_SIGN) == 0)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void brk()
    {
        PC++;
        push16(PC); //push next instruction address onto stack
        push8((byte)(STATUS | FLAG_BREAK)); //push CPU status to stack
        setinterruptdisable(); //set interrupt flag
        PC = (ushort)(_read6502(0xFFFE) | (_read6502(0xFFFF) << 8));
    }

    private void bvc()
    {
        if ((STATUS & FLAG_OVERFLOW) == 0)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void bvs()
    {
        if ((STATUS & FLAG_OVERFLOW) == FLAG_OVERFLOW)
        {
            oldpc = PC;
            PC += reladdr;
            if ((oldpc & 0xFF00) != (PC & 0xFF00)) ClockTicks6502 += 2; //check if jump crossed a page boundary
            else ClockTicks6502++;
        }
    }

    private void clc()
    {
        clearcarry();
    }

    private void cld()
    {
        cleardecimal();
    }

    private void cli()
    {
        clearinterruptdisable();
    }

    private void clv()
    {
        clearoverflow();
    }

    private void cmp()
    {
        penaltyop = 1;
        value = getvalue();
        result = (ushort)(A - value);

        if (A >= (byte)(value & 0x00FF)) setcarry();
        else clearcarry();
        if (A == (byte)(value & 0x00FF)) setzero();
        else clearzero();
        signcalc(result);
    }

    private void cpx()
    {
        value = getvalue();
        result = (ushort)(X - value);

        if (X >= (byte)(value & 0x00FF)) setcarry();
        else clearcarry();
        if (X == (byte)(value & 0x00FF)) setzero();
        else clearzero();
        signcalc(result);
    }

    private void cpy()
    {
        value = getvalue();
        result = (ushort)(Y - value);

        if (Y >= (byte)(value & 0x00FF)) setcarry();
        else clearcarry();
        if (Y == (byte)(value & 0x00FF)) setzero();
        else clearzero();
        signcalc(result);
    }

    private void dec()
    {
        value = getvalue();
        result = (ushort)(value - 1);

        zerocalc(result);
        signcalc(result);

        putvalue(result);
    }

    private void dex()
    {
        X--;

        zerocalc(X);
        signcalc(X);
    }

    private void dey()
    {
        Y--;

        zerocalc(Y);
        signcalc(Y);
    }

    private void eor()
    {
        penaltyop = 1;
        value = getvalue();
        result = (ushort)(A ^ value);

        zerocalc(result);
        signcalc(result);

        saveaccum(result);
    }

    private void inc()
    {
        value = getvalue();
        result = (ushort)(value + 1);

        zerocalc(result);
        signcalc(result);

        putvalue(result);
    }

    private void inx()
    {
        X++;

        zerocalc(X);
        signcalc(X);
    }

    private void iny()
    {
        Y++;

        zerocalc(Y);
        signcalc(Y);
    }

    private void jmp()
    {
        PC = ea;
    }

    private void jsr()
    {
        push16((ushort)(PC - 1));
        PC = ea;
    }

    private void lda()
    {
        penaltyop = 1;
        value = getvalue();
        A = (byte)(value & 0x00FF);

        zerocalc(A);
        signcalc(A);
    }

    private void ldx()
    {
        penaltyop = 1;
        value = getvalue();
        X = (byte)(value & 0x00FF);

        zerocalc(X);
        signcalc(X);
    }

    private void ldy()
    {
        penaltyop = 1;
        value = getvalue();
        Y = (byte)(value & 0x00FF);

        zerocalc(Y);
        signcalc(Y);
    }

    private void lsr()
    {
        value = getvalue();
        result = (ushort)(value >> 1);

        if ((ushort)(value & 1) != 0)
            setcarry();
        else
            clearcarry();
        zerocalc(result);
        signcalc(result);

        putvalue(result);
    }

    private void nop()
    {
        switch (opcode)
        {
            case 0x1C:
            case 0x3C:
            case 0x5C:
            case 0x7C:
            case 0xDC:
            case 0xFC:
                penaltyop = 1;
                break;
        }
    }

    private void ora()
    {
        penaltyop = 1;
        value = getvalue();
        result = (ushort)(A | value);

        zerocalc(result);
        signcalc(result);

        saveaccum(result);
    }

    private void pha()
    {
        push8(A);
    }

    private void php()
    {
        push8((byte)(STATUS | FLAG_BREAK));
    }

    private void pla()
    {
        A = pull8();

        zerocalc(A);
        signcalc(A);
    }

    private void plp()
    {
        STATUS = (byte)(pull8() & ~FLAG_BREAK);
    }

    private void rol()
    {
        value = getvalue();
        result = (ushort)((ushort)(value << 1) | (ushort)(STATUS & FLAG_CARRY));

        carrycalc(result);
        zerocalc(result);
        signcalc(result);

        putvalue(result);
    }

    private void ror()
    {
        value = getvalue();
        result = (ushort)((ushort)(value >> 1) | (ushort)((STATUS & FLAG_CARRY) << 7));

        if ((ushort)(value & 1) != 0) setcarry();
        else clearcarry();
        zerocalc(result);
        signcalc(result);

        putvalue(result);
    }

    private void rti()
    {
        STATUS = pull8();
        value = pull16();
        PC = value;
    }

    private void rts()
    {
        value = pull16();
        PC = (ushort)(value + 1);
    }

    private void sbc()
    {
        penaltyop = 1;
        value = (ushort)(getvalue() ^ 0x00FF);
        result = (ushort)(A + value + (ushort)(STATUS & FLAG_CARRY));

        carrycalc(result);
        zerocalc(result);
        overflowcalc(result, A, value);
        signcalc(result);

        if (_allowDecimalMode && (byte)(STATUS & FLAG_DECIMAL) != 0)
        {
            clearcarry();

            A -= 0x66;
            if ((A & 0x0F) > 0x09)
            {
                A += 0x06;
            }
            if ((A & 0xF0) > 0x90)
            {
                A += 0x60;
                setcarry();
            }

            ClockTicks6502++;
        }

        saveaccum(result);
    }

    private void sec()
    {
        setcarry();
    }

    private void sed()
    {
        setdecimal();
    }

    private void sei()
    {
        setinterruptdisable();
    }

    private void sta()
    {
        putvalue(A);
    }

    private void stx()
    {
        putvalue(X);
    }

    private void sty()
    {
        putvalue(Y);
    }

    private void tax()
    {
        X = A;

        zerocalc(X);
        signcalc(X);
    }

    private void tay()
    {
        Y = A;

        zerocalc(Y);
        signcalc(Y);
    }

    private void tsx()
    {
        X = SP;

        zerocalc(X);
        signcalc(X);
    }

    private void txa()
    {
        A = X;

        zerocalc(A);
        signcalc(A);
    }

    private void txs()
    {
        SP = X;
    }

    private void tya()
    {
        A = Y;

        zerocalc(A);
        signcalc(A);
    }

    //undocumented instructions
    private void lax()
    {
        lda();
        ldx();
    }

    private void sax()
    {
        sta();
        stx();
        putvalue((ushort)(A & X));
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }

    private void dcp()
    {
        dec();
        cmp();
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }

    private void isb()
    {
        inc();
        sbc();
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }

    private void slo()
    {
        asl();
        ora();
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }

    private void rla()
    {
        rol();
        and();
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }

    private void sre()
    {
        lsr();
        eor();
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }

    private void rra()
    {
        ror();
        adc();
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502--;
    }



    private readonly uint[] ticktable = new uint[]{
    /*        |  0  |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  |  A  |  B  |  C  |  D  |  E  |  F  |     */
    /* 0 */      7,    6,    2,    8,    3,    3,    5,    5,    3,    2,    2,    2,    4,    4,    6,    6,  /* 0 */
    /* 1 */      2,    5,    2,    8,    4,    4,    6,    6,    2,    4,    2,    7,    4,    4,    7,    7,  /* 1 */
    /* 2 */      6,    6,    2,    8,    3,    3,    5,    5,    4,    2,    2,    2,    4,    4,    6,    6,  /* 2 */
    /* 3 */      2,    5,    2,    8,    4,    4,    6,    6,    2,    4,    2,    7,    4,    4,    7,    7,  /* 3 */
    /* 4 */      6,    6,    2,    8,    3,    3,    5,    5,    3,    2,    2,    2,    3,    4,    6,    6,  /* 4 */
    /* 5 */      2,    5,    2,    8,    4,    4,    6,    6,    2,    4,    2,    7,    4,    4,    7,    7,  /* 5 */
    /* 6 */      6,    6,    2,    8,    3,    3,    5,    5,    4,    2,    2,    2,    5,    4,    6,    6,  /* 6 */
    /* 7 */      2,    5,    2,    8,    4,    4,    6,    6,    2,    4,    2,    7,    4,    4,    7,    7,  /* 7 */
    /* 8 */      2,    6,    2,    6,    3,    3,    3,    3,    2,    2,    2,    2,    4,    4,    4,    4,  /* 8 */
    /* 9 */      2,    6,    2,    6,    4,    4,    4,    4,    2,    5,    2,    5,    5,    5,    5,    5,  /* 9 */
    /* A */      2,    6,    2,    6,    3,    3,    3,    3,    2,    2,    2,    2,    4,    4,    4,    4,  /* A */
    /* B */      2,    5,    2,    5,    4,    4,    4,    4,    2,    4,    2,    4,    4,    4,    4,    4,  /* B */
    /* C */      2,    6,    2,    8,    3,    3,    5,    5,    2,    2,    2,    2,    4,    4,    6,    6,  /* C */
    /* D */      2,    5,    2,    8,    4,    4,    6,    6,    2,    4,    2,    7,    4,    4,    7,    7,  /* D */
    /* E */      2,    6,    2,    8,    3,    3,    5,    5,    2,    2,    2,    2,    4,    4,    6,    6,  /* E */
    /* F */      2,    5,    2,    8,    4,    4,    6,    6,    2,    4,    2,    7,    4,    4,    7,    7   /* F */
};


    public void IssueNMI()
    {
        push16(PC);
        push8(STATUS);
        STATUS |= FLAG_INTERRUPT_DISABLE;
        PC = (ushort)(_read6502(0xFFFA) | (_read6502(0xFFFB) << 8));
    }

    public void IssueIRQ()
    {
        if ((STATUS & FLAG_INTERRUPT_DISABLE) == FLAG_INTERRUPT_DISABLE)
            return;

        push16(PC);
        push8(STATUS);
        STATUS |= FLAG_INTERRUPT_DISABLE;
        PC = (ushort)(_read6502(0xFFFE) | (_read6502(0xFFFF) << 8));
    }


    public void Step()
    {
        opcode = _read6502(PC++);

        penaltyop = 0;
        penaltyaddr = 0;

        addrtable[opcode]();
        optable[opcode]();
        ClockTicks6502 += ticktable[opcode];
        if (penaltyop != 0 && penaltyaddr != 0) ClockTicks6502++;

        InstructionCount++;
    }
}
