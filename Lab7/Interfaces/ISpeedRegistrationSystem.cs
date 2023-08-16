using Lab7.Event;

namespace Lab7;

public interface ISpeedRegistrationSystem
{
    bool CheckSpeed(AVehicle vehicle);
    bool CheckSpeed(VehicleEventArgs args);
}