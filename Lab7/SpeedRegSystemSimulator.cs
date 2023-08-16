using Lab7.Event;

namespace Lab7;

public class SpeedRegSystemSimulator : ISpeedRegistrationSystem
{
    public bool CheckSpeed(AVehicle vehicle)
    {
        return vehicle.GetSpeed() > 110;
    }

    public bool CheckSpeed(VehicleEventArgs args)
    {
        return args.Speed > 110;
    }
}