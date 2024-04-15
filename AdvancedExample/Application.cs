// Application that uses the DriverWrapper
public class Application
{
    private readonly DriverWrapper _driverWrapper;

    public Application(DriverWrapper driverWrapper)
    {
        _driverWrapper = driverWrapper;
    }

    public void ProcessData(string rawData)
    {
        _driverWrapper.SendData(rawData);
    }
}