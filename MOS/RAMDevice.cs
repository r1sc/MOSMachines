namespace MOS;
public class RAMDevice : IDevice
{
    public byte[] Data;

    public RAMDevice(byte[] data)
    {
        Data = data;
    }

    public byte Read(ushort address)
    {
        return Data[address];
    }

    public void Write(ushort address, byte value)
    {
        Data[address] = value;
    }
}
