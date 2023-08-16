using Lab7.Event;

namespace Lab7;

public class TrafficFlowTerminalStolen
{
    private CheckPoint _checkPoint;

    public TrafficFlowTerminalStolen(CheckPoint checkPoint)
    {
        _checkPoint = checkPoint;
        _checkPoint.OnVehicleStolen += EventHandler;
    }

    public void Dispose()
    {
        _checkPoint.OnVehicleStolen -= EventHandler;
    }

    private void EventHandler(object sender, VehicleEventArgs args)
    {
        if (_checkPoint.RegSystem.CheckLicensePlateNumber(args.LicensePlateNumber)) 
            Console.WriteLine("Перехват!");
    }
}