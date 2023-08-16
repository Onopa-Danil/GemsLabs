using Lab7.Event;

namespace Lab7;

public class TrafficFlowTerminalRandom : IDisposable
{
    private CheckPoint _checkPoint;
    private Random _random;

    public TrafficFlowTerminalRandom(CheckPoint checkPoint)
    {
        _checkPoint = checkPoint;
        _random = new Random();
        _checkPoint.OnVehiclePass += EventHandler;
    }

    public void Dispose()
    {
        _checkPoint.OnVehiclePass -= EventHandler;
    }

    private void EventHandler(object sender, VehicleEventArgs args)
    {
        int randomNumber = _random.Next(0, 2);
        if (randomNumber == 1)
        {
            _checkPoint.InvokeEvents(args);
            Console.WriteLine(args.ToString());
            Thread.Sleep(_random.Next(500, 5001));
        }
    }
}