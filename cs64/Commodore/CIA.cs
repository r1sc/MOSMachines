using MOS;
using System.Runtime.CompilerServices;

namespace cs64
{
    class CIA : IDevice
    {
        

        public enum Register : ushort
        {
            PeripheralDataRegA = 0,
            PeripheralDataRegB = 1,
            DataDirectionRegA = 2,
            DataDirectionRegB = 3,
            TimerALowReg = 4,
            TimerAHighReg = 5,
            TimerBLowReg = 6,
            TimerBHighReg = 7,
            TOD10thReg = 8,
            TODSecReg = 9,
            TODMinReg = 10,
            TODHourReg = 11,
            SerialDataReg = 12,
            InterrutControlReg = 13,
            ControlRegA = 14,
            ControlRegB = 15
        }

        [Flags()]
        public enum ControlBitsA : byte
        {
            Start = 1 << 0,
            PBON = 1 << 1,
            OUTMODE = 1 << 2,
            IsOneShot = 1 << 3,
            LOAD = 1 << 4,
            INMODE = 1 << 5,
            SPMODE = 1 << 6,
            TODIN = 1 << 7
        }

        [Flags()]
        public enum ControlBitsB : byte
        {
            Start = 1 << 0,
            PBON = 1 << 1,
            OUTMODE = 1 << 2,
            IsOneShot = 1 << 3,
            LOAD = 1 << 4,
            INMODE_LO = 1 << 5,
            INMODE_HI = 1 << 6,
            TODIN = 1 << 7
        }

        public ControlBitsA CRA { get; set; }

        public ControlBitsB CRB { get; set; }

        [Flags()]
        private enum InterruptControlMask : byte
        {
            TimerA = 1 << 0,
            TimerB = 1 << 1,
            Alarm = 1 << 2,
            SP = 1 << 3,
            Flag = 1 << 4,
            SetClear = 1 << 7
        }

        [Flags()]
        private enum InterruptControlData : byte
        {
            TimerA = 1 << 0,
            TimerB = 1 << 1,
            Alarm = 1 << 2,
            SP = 1 << 3,
            Flag = 1 << 4,
            InterruptRequest = 1 << 7
        }
        private byte _ddra;
        private byte _ddrb;
        private Timer _timerA;
        private Timer _timerB;

        private InterruptControlMask _interruptControlMask;
        private InterruptControlData _interruptControlData;

        private readonly Action _issueIRQ;
        private readonly Func<Port, byte> _readPort;
        private readonly Action<Port, byte> _writePort;

        public enum Port
        {
            A,
            B
        }

        public CIA(Action issueIRQ, Func<Port, byte> readPort, Action<Port, byte> writePort)
        {
            _issueIRQ = issueIRQ;
            _timerA = new Timer();
            _timerB = new Timer();

            _readPort = readPort;
            _writePort = writePort;
        }

        public void Step()
        {
            bool issureIrq = false;

            if (_timerA.Running)
            {
                _timerA.Tick();
                if (_timerA.ActualValue == 0)
                {
                    _interruptControlData |= InterruptControlData.TimerA;
                    if (_interruptControlMask.HasFlag(InterruptControlMask.TimerA))
                        issureIrq = true;
                }
            }

            if (_timerB.Running)
            {
                _timerB.Tick();
                if (_timerB.ActualValue == 0)
                {
                    _interruptControlData |= InterruptControlData.TimerB;
                    if (_interruptControlMask.HasFlag(InterruptControlMask.TimerB))
                        issureIrq = true;
                }
            }

            if (issureIrq)
            {
                _interruptControlData |= InterruptControlData.InterruptRequest;
                _issueIRQ();
            }
        }

        public byte Read(ushort address)
        {
            var register = (Register)address;
            switch (register)
            {
                case Register.PeripheralDataRegA:
                    {
                        return 0x81;
                    }
                case Register.PeripheralDataRegB:
                    {
                        return 0xFF;
                    }
                case Register.DataDirectionRegA:
                    return _ddra;
                case Register.DataDirectionRegB:
                    return _ddrb;
                case Register.TimerALowReg:
                    return _timerA.ActualValueLoByte;
                case Register.TimerAHighReg:
                    return _timerA.ActualValueHiByte;
                case Register.TimerBLowReg:
                    return _timerB.ActualValueLoByte;
                case Register.TimerBHighReg:
                    return _timerB.ActualValueHiByte;
                case Register.TOD10thReg:
                    return 0;
                case Register.TODSecReg:
                    return 0;
                case Register.TODMinReg:
                    return 0;
                case Register.TODHourReg:
                    return 0;
                case Register.SerialDataReg:
                    return 0;
                case Register.InterrutControlReg:
                    var d = _interruptControlData;
                    _interruptControlData = 0;
                    return (byte)d;
                case Register.ControlRegA:
                    {
                        var oldValue = (byte)CRA;
                        CRA = 0;
                        return oldValue;
                    }
                case Register.ControlRegB:
                    {
                        var oldValue = (byte)CRB;
                        CRB = 0;
                        return oldValue;
                    }
                default:
                    throw new ArgumentOutOfRangeException($"Address out of range: {address}");
            }
        }

        public void Write(ushort address, byte value)
        {
            var register = (Register)address;
            switch (register)
            {
                case Register.PeripheralDataRegA:
                    _writePort(Port.A, value);
                    break;
                case Register.PeripheralDataRegB:
                    _writePort(Port.B, value);
                    break;
                case Register.DataDirectionRegA:
                    _ddra = value;
                    break;
                case Register.DataDirectionRegB:
                    _ddrb = value;
                    break;
                case Register.TimerALowReg:
                    _timerA.Latch = (ushort)((_timerA.LatchHiByte << 8) | value);
                    break;
                case Register.TimerAHighReg:
                    _timerA.Latch = (ushort)((value << 8) | _timerA.LatchLoByte);
                    _timerA.ActualValue = _timerA.Latch;
                    break;
                case Register.TimerBLowReg:
                    _timerA.Latch = (ushort)((_timerB.LatchHiByte << 8) | value);
                    break;
                case Register.TimerBHighReg:
                    _timerB.Latch = (ushort)((value << 8) | _timerA.LatchLoByte);
                    _timerB.ActualValue = _timerB.Latch;
                    break;
                case Register.TOD10thReg:
                    break;
                case Register.TODSecReg:
                    break;
                case Register.TODMinReg:
                    break;
                case Register.TODHourReg:
                    break;
                case Register.SerialDataReg:
                    break;
                case Register.InterrutControlReg:
                    var set = (value & (byte)InterruptControlMask.SetClear) == (byte)InterruptControlMask.SetClear;
                    if (set)
                    {
                        _interruptControlMask |= (InterruptControlMask)(value & 127);
                    }
                    else
                    {
                        _interruptControlMask &= (InterruptControlMask)~value;
                    }
                    break;
                case Register.ControlRegA:
                    {
                        CRA = (ControlBitsA)value & (~ControlBitsA.LOAD);
                        var controlChange = (ControlBitsA)value;

                        _timerA.Running = controlChange.HasFlag(ControlBitsA.Start);
                        _timerA.StopAfterUnderflow = controlChange.HasFlag(ControlBitsA.IsOneShot);

                        if (controlChange.HasFlag(ControlBitsA.LOAD))
                        {
                            _timerA.ActualValue = _timerA.Latch;
                        }
                    }
                    break;
                case Register.ControlRegB:
                    {
                        CRB = (ControlBitsB)value & (~ControlBitsB.LOAD);

                        var controlChange = (ControlBitsB)value;

                        _timerB.Running = controlChange.HasFlag(ControlBitsB.Start);
                        _timerB.StopAfterUnderflow = controlChange.HasFlag(ControlBitsB.IsOneShot);                        

                        if (controlChange.HasFlag(ControlBitsB.LOAD))
                        {
                            _timerB.ActualValue = _timerB.Latch;
                        }
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Address out of range: {address}");
            }
        }

        public class Timer
        {
            public ushort ActualValue { get; set; }
            public ushort Latch { get; set; }

            public bool Running { get; set; }
            public bool StopAfterUnderflow { get; set; }

            public byte ActualValueHiByte => (byte)(ActualValue >> 8);
            public byte LatchHiByte => (byte)(Latch >> 8);
            public byte ActualValueLoByte => (byte)(ActualValue & 0xFF);
            public byte LatchLoByte => (byte)(Latch & 0xFF);

            public void Tick()
            {
                if (Running)
                {
                    if (ActualValue > 0) {
                        ActualValue--;
                    }
                    else
                    {
                        if (StopAfterUnderflow)
                        {
                            Running = false; // Stop timer
                        }

                        ActualValue = Latch;
                    }
                }
            }
        }
    }
}