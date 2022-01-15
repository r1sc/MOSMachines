using MOS;

namespace cs64
{
    class CIA1 : IDevice
    {

        public byte PRA { get; private set; }
        public byte DDRA { get; private set; }
        public byte PRB { get; private set; }
        public byte DDRB { get; private set; }
        public Timer TimerA;
        public Timer TimerB;

        public byte InterruptControl;

        private byte IRQReason;
        private readonly Action _issueIRQ;

        public CIA1(Action issueIRQ)
        {
            _issueIRQ = issueIRQ;
            TimerA = new Timer();
            TimerB = new Timer();
        }

        public void Step()
        {
            TimerA.Tick();
            if (TimerA.Underflow && (InterruptControl & 1) == 1)
                _issueIRQ();

            TimerB.Tick();
            if (TimerB.Underflow && (InterruptControl & 2) == 2)
                _issueIRQ();

        }

        public byte Read(ushort address)
        {
            var localAddress = (ushort)(address & 0x0F);
            switch (localAddress)
            {
                case 0x00:
                    return PRA;
                case 0x01:
                    return PRB;
                case 0x02:
                    return DDRA;
                case 0x03:
                    return DDRB;
                case 0x04:
                    return (byte)(TimerA.ActualValue & 0xFF);
                case 0x05:
                    return (byte)((TimerA.ActualValue >> 8) & 0xFF);
                case 0x06:
                    return (byte)(TimerB.ActualValue & 0xFF);
                case 0x07:
                    return (byte)((TimerB.ActualValue >> 8) & 0xFF);
                case 0x0D:
                    var timerAUnderflow = TimerA.Underflow ? 1 : 0;
                    var timerBUnderflow = TimerB.Underflow ? 1 : 0;
                    return 0;
                default:
                    return 0;
            }
        }

        public void Write(ushort address, byte value)
        {
            address = (ushort)(address % 0x10);
            switch (address)
            {
                case 0x00:
                    PRA = (byte)(PRA | (value & DDRA));
                    break;
                case 0x01:
                    PRB = (byte)(PRB | (value & DDRB));
                    break;
                case 0x02:
                    DDRA = value;
                    break;
                case 0x03:
                    DDRB = value;
                    break;
                case 0x04:
                    TimerA.Latch = (ushort)(TimerA.Latch | value);
                    break;
                case 0x05:
                    TimerA.Latch = (ushort)(TimerA.Latch | (value << 8));
                    break;
                case 0x06:
                    TimerB.Latch = (ushort)(TimerB.Latch | value);
                    break;
                case 0x07:
                    TimerB.Latch = (ushort)(TimerB.Latch | (value << 8));
                    break;
            }
        }

        public class Timer
        {
            public ushort ActualValue { get; set; }
            public ushort Latch { get; set; }

            public bool Running { get; private set; }
            public bool StopAfterUnderflow { get; private set; }
            public bool Underflow { get; private set; }


            private byte _control;

            public byte Control
            {
                set
                {
                    _control = value;

                    Running = (value & 1) == 1;
                    if (Running)
                    {
                        Underflow = false;
                    }

                    StopAfterUnderflow = (value & 3) == 3;

                    var loadLatch = (value & 4) == 4;
                    if (loadLatch)
                    {
                        ActualValue = Latch;
                    }
                }
                get => _control;
            }

            public void Tick()
            {
                if (Underflow)
                {
                    if (StopAfterUnderflow)
                        Running = false;
                    else
                        ActualValue = Latch;
                }
                if (Running)
                {
                    if (ActualValue == 0)
                    {
                        Underflow = true;
                    }
                    else
                    {
                        ActualValue--;
                    }

                }
            }
        }
    }
}