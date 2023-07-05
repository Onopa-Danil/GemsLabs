namespace Lab3;

public class Car : AVehicle
{
    public Car(VehicleColor color,  int licensePlateNumber, bool hasPassenger, int speed) :
        base(color, VehicleBodyType.Car, licensePlateNumber, hasPassenger, speed){}

    public override int GetSpeed()
    {
        return Speed;
    }
}