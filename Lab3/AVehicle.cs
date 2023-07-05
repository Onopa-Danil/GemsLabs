namespace Lab3;

public abstract class AVehicle
{
    public VehicleColor Color { get; private set; }
    public VehicleBodyType BodyType { get; private set; }
    public int LicensePlateNumber { get; private set; }
    public bool HasPassenger { get; private set; }
    protected int Speed;

    protected AVehicle
        (VehicleColor color, VehicleBodyType bodyType, int licensePlateNumber, bool hasPassenger, int speed)
    {
        Color = color;
        BodyType = bodyType;
        LicensePlateNumber = licensePlateNumber;
        HasPassenger = hasPassenger;
        Speed = speed;
    }

    public virtual int GetSpeed()
    {
        return 0;
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
        str += "Регистрационный номер: " + LicensePlateNumber.ToString() + "\n";
        str += "Есть ли пассажир: " + (HasPassenger ? "да" : "нет") + "\n";
        str += "Скорость: " + Speed.ToString() + " км\\ч";
        return str;
    }
}