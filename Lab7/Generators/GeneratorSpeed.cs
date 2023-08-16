namespace Lab7;

public class GeneratorSpeed : IGeneratorSpeed
{
    
    private Random _random = new Random();
    
    public int GenerateSpeed(VehicleBodyType bodyType)
    {
        if (bodyType == VehicleBodyType.Bus)
            return _random.Next(80, 111);
        if (bodyType == VehicleBodyType.Truck)
            return _random.Next(70, 101);
        if (bodyType == VehicleBodyType.Car)
            return _random.Next(90, 151);
        throw new ArgumentException("not correct bodyType");
    }
}