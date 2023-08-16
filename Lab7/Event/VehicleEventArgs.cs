namespace Lab7.Event;

public class VehicleEventArgs : EventArgs
{
    public VehicleColor Color { get; private set; }
    public VehicleBodyType BodyType { get; private set; }
    public int LicensePlateNumber { get; private set; }
    public bool HasPassenger { get; private set; }
    public int Speed { get; private set; }
    
    public VehicleEventArgs (AVehicle vehicle)
    {
        Color = vehicle.Color;
        BodyType = vehicle.BodyType;
        LicensePlateNumber = vehicle.LicensePlateNumber;
        HasPassenger = vehicle.HasPassenger;
        Speed = vehicle.GetSpeed();
    }
    public override string ToString()
    {
        string str = "Цвет кузова: ";
        if ((int)Color == 0) str += "красный\n";
        else if ((int)Color == 1) str += "оранжевый\n";
        else if ((int)Color == 2) str += "желтый\n";
        else if ((int)Color == 3) str += "зеленый\n";
        else if ((int)Color == 4) str += "голубой\n";
        else if ((int)Color == 5) str += "синий\n";
        else if ((int)Color == 6) str += "фиолетовый\n";
        str += "Тип автомобиля: ";
        if ((int)BodyType == 0) str += "легковой автомобиль\n";
        else if ((int)BodyType == 1) str += "грузовой автомобиль\n";
        else if ((int)BodyType == 2) str += "автобус\n";
        str += "Регистрационный номер: " + LicensePlateNumber + "\n";
        str += "Есть ли пассажир: " + (HasPassenger ? "да" : "нет") + "\n";
        str += "Скорость: " + Speed + " км\\ч";
        return str;
    }
}