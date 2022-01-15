namespace MOS
{
    public class ROMDevice : IDevice
    {
        public byte[] Data;

        public ROMDevice(byte[] data)
        {
            Data = data;
        }

        public byte Read(ushort address)
        {
            return Data[address];
        }

        public void Write(ushort address, byte value)
        {
            // Read only
        }
    }
}