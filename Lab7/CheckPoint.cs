using Lab7.Event;

namespace Lab7;

public class CheckPoint
{
    public CheckPointStatistics Statistics { get; private set; }
    public ITheftRegistrationSystem RegSystem { get; private set; }
    public ISpeedRegistrationSystem SpeedSystem { get; private set; }

    public event EventHandler<VehicleEventArgs>? OnVehiclePass; 
    public event EventHandler<VehicleEventArgs>? OnVehicleSpeeding; 
    public event EventHandler<VehicleEventArgs>? OnVehicleStolen; 

    public CheckPoint(ITheftRegistrationSystem regSystem, ISpeedRegistrationSystem speedSystem)
    {
        RegSystem = regSystem;
        SpeedSystem = speedSystem;
        Statistics = new CheckPointStatistics();
    }

    public void InvokeEvents(VehicleEventArgs args)
    {
        OnVehicleSpeeding?.Invoke(null, args);
        OnVehicleStolen?.Invoke(null, args);
    }
    
    public void RegisterVehicle(AVehicle vehicle)
    {
        OnVehiclePass?.Invoke(null, new VehicleEventArgs(vehicle));
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