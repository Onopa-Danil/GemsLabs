namespace Lab3;

public class CheckPointStatistics
{
    public int CarsCount { get; set; }
    public int TrucksCount { get; set; }
    public int BusesCount { get; set; }
    public int SpeedLimitBreakersCount { get; set; }
    public int CarJackersCount { get; set; }
    private long _sumOfSpeeds;
    public int AverageSpeed
    {
        get
        {
            int sum = CarsCount + TrucksCount + BusesCount;
            return sum == 0 ? 0 : (int) _sumOfSpeeds / sum;
        }
    }

    public void ChangeAverageSpeed(long speed)
    {
        _sumOfSpeeds += speed;
    }
    public CheckPointStatistics()
    {
        CarsCount = 0;
        TrucksCount = 0;
        BusesCount = 0;
        SpeedLimitBreakersCount = 0;
        CarJackersCount = 0;
        _sumOfSpeeds = 0;
    }

    public override string ToString()
    {
        string str = "";
        str += "Общее количество машин: " + (CarsCount + TrucksCount + BusesCount) + "\n";
        str += "Количество легковых автомобилей: " + CarsCount + "\n";
        str += "Количество грузовых автомобилей: " + TrucksCount + "\n";
        str += "Количество автобусов: " + BusesCount + "\n";
        str += "Количество автомобилей, которые превысили скорость: " + SpeedLimitBreakersCount + "\n";
        str += "Количество автомобилей, которые числятся в угоне: " + CarJackersCount + "\n";
        str += "Средняя скорость: " + AverageSpeed + " км\\ч\n";
        return str;
    }
}