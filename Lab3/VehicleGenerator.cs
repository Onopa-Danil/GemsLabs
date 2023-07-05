namespace Lab3;

public class VehicleGenerator : IVehicleGenerator
{
    private IGeneratorSpeed GeneratorSpeed { get; set; }
    private Random _random;

    public VehicleGenerator(IGeneratorSpeed generatorSpeed)
    {
        GeneratorSpeed = generatorSpeed;
        _random = new Random();
    }

    public AVehicle Generate()
    {
        VehicleBodyType bodyType = (VehicleBodyType) _random.Next(0, 3);
        VehicleColor color = (VehicleColor) _random.Next(0, 7);
        int licensePlateNumber = _random.Next(100, 1000);
        bool hasPassenger = _random.Next(0, 2) == 1;
        int speed = GeneratorSpeed.GenerateSpeed(bodyType);
        
        if (bodyType == VehicleBodyType.Bus)
            return new Bus(color, licensePlateNumber, hasPassenger, speed);
        
        if (bodyType == VehicleBodyType.Car)
            return new Car(color, licensePlateNumber, hasPassenger, speed);
        
        if (bodyType == VehicleBodyType.Truck)
            return new Truck(color, licensePlateNumber, hasPassenger, speed);
        
        throw new Exception("something went wrong");
    }
}