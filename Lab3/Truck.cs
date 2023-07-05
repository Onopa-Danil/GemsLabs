namespace Lab3;

public class Truck : AVehicle
{
    public Truck(VehicleColor color,  int licensePlateNumber, bool hasPassenger, int speed) :
        base(color, VehicleBodyType.Truck, licensePlateNumber, hasPassenger, speed){}

    public override int GetSpeed()
    {
        return Speed;
    }
}