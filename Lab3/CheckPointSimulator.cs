namespace Lab3;

public class CheckPointSimulator
{
    public static void startSimulation(IVehicleGenerator vehicleGenerator, CheckPoint checkPoint,
        ISpeedRegistrationSystem speedRegistrationSystem, ITheftRegistrationSystem theftRegistrationSystem)
    {
        Random random = new Random();
        Console.WriteLine("Через 10 секунд начнется симуляция. Нажмите любую клавишу, чтобы ее закончить.");
        System.Threading.Thread.Sleep(10000);
        while (!Console.KeyAvailable)
        {
            Console.Clear();
            AVehicle vehicle = vehicleGenerator.Generate();
            checkPoint.RegisterVehicle(vehicle);
            if (speedRegistrationSystem.CheckSpeed(vehicle)) Console.WriteLine("Превышение скорости!");
            if (theftRegistrationSystem.CheckLicensePlateNumber(vehicle.LicensePlateNumber)) Console.WriteLine("Перехват!");
            Console.WriteLine(vehicle.ToString());
            System.Threading.Thread.Sleep(random.Next(500, 5001));
        }
        Console.Clear();
        Console.WriteLine(checkPoint.Statistics.ToString());
    }
}