namespace Lab3;

public class Bus : AVehicle
{
    public Bus(VehicleColor color,  int licensePlateNumber, bool hasPassenger, int speed) :
        base(color, VehicleBodyType.Bus, licensePlateNumber, hasPassenger, speed){}

    public override int GetSpeed()
    {
        return Speed;
    }
}