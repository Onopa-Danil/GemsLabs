using Lab7.Event;

namespace Lab7;

public class TrafficFlowTerminalSpeeding : IDisposable
{
    private CheckPoint _checkPoint;

    public TrafficFlowTerminalSpeeding(CheckPoint checkPoint)
    {
        _checkPoint = checkPoint;
        _checkPoint.OnVehicleSpeeding += EventHandler;
    }

    public void Dispose()
    {
        _checkPoint.OnVehicleSpeeding -= EventHandler;
    }

    private void EventHandler(object sender, VehicleEventArgs args)
    {
        if (_checkPoint.SpeedSystem.CheckSpeed(args)) Console.WriteLine("Превышение скорости!");
    }
}