namespace Lab3;

public class SpeedRegSystemSimulator : ISpeedRegistrationSystem
{
    public bool CheckSpeed(AVehicle vehicle)
    {
        return vehicle.GetSpeed() > 110;
    }
}