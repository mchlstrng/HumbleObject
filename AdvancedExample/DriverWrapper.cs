// Humble Object for the driver that communicates with a device
public class DriverWrapper
{
    private readonly DataFormatter _dataFormatter;
    private readonly Device _device;

    public DriverWrapper(DataFormatter dataFormatter, Device device)
    {
        _dataFormatter = dataFormatter;
        _device = device;
    }

    public void SendData(string rawData)
    {
        string formattedData = _dataFormatter.FormatData(rawData);
        _device.Send(formattedData);
    }
}