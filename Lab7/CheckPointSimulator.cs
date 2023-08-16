namespace Lab7;

public class CheckPointSimulator
{
    public static void StartSimulation(IVehicleGenerator vehicleGenerator, CheckPoint checkPoint,
        ISpeedRegistrationSystem speedRegistrationSystem, ITheftRegistrationSystem theftRegistrationSystem)
    {
        Console.WriteLine("Через 10 секунд начнется симуляция. Нажмите любую клавишу, чтобы ее закончить.");
        Thread.Sleep(10000);
        var trafficFlowTerminalRandom = new TrafficFlowTerminalRandom(checkPoint);
        var trafficFlowTerminalSpeeding = new TrafficFlowTerminalSpeeding(checkPoint);
        var trafficFlowTerminalStolen = new TrafficFlowTerminalStolen(checkPoint);
        try
        {
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                AVehicle vehicle = vehicleGenerator.Generate();
                checkPoint.RegisterVehicle(vehicle);
            }
        }
        finally
        {
            trafficFlowTerminalRandom.Dispose();
            trafficFlowTerminalSpeeding.Dispose();
            trafficFlowTerminalStolen.Dispose();
        }
        Console.Clear();
        Console.WriteLine(checkPoint.Statistics.ToString());
    }
}