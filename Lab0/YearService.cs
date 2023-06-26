namespace Lab0
{
    public class YearService
    {
        public static bool IsItLeapYear(int year)
        {
            if (year < 0) throw new ArgumentException("year < 0");
            if (year % 4 == 0 && year % 100 != 0) return true;
            return year % 400 == 0;
        }
    }
}