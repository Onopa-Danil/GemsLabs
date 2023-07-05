namespace Lab3;

public class CheckPoint
{
    public CheckPointStatistics Statistics { get; private set; }
    private ITheftRegistrationSystem RegSystem { get; set; }
    private ISpeedRegistrationSystem SpeedSystem { get; set; }

    public CheckPoint(ITheftRegistrationSystem regSystem, ISpeedRegistrationSystem speedSystem)
    {
        RegSystem = regSystem;
        SpeedSystem = speedSystem;
        Statistics = new CheckPointStatistics();
    }
    
    public void RegisterVehicle(AVehicle vehicle)
    {
        if (vehicle.BodyType == VehicleBodyType.Bus)
            Statistics.BusesCount++;
        else if (vehicle.BodyType == VehicleBodyType.Car)
            Statistics.CarsCount++;
        else if (vehicle.BodyType == VehicleBodyType.Truck)
            Statistics.TrucksCount++;
        else throw new ArgumentException("not correct vehicle");
        if (SpeedSystem.CheckSpeed(vehicle)) Statistics.SpeedLimitBreakersCount++;
        if (RegSystem.CheckLicensePlateNumber(vehicle.LicensePlateNumber)) Statistics.CarJackersCount++;
        Statistics.ChangeAverageSpeed(vehicle.GetSpeed());
    }
}