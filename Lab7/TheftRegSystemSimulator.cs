namespace Lab7;

public class TheftRegSystemSimulator : ITheftRegistrationSystem
{
    private ISet<int> LicensePlateNumbers { get; set; }

    public TheftRegSystemSimulator()
    {
        LicensePlateNumbers = new HashSet<int>();
        Random random = new Random();
        int count = random.Next(150, 310);
        for (int i = 0; i < count; i++)
        {
            LicensePlateNumbers.Add(random.Next(100, 1000));
        }
    }

    public bool CheckLicensePlateNumber(int checkLicensePlateNumber)
    {
        return LicensePlateNumbers.Contains(checkLicensePlateNumber);
    }
}