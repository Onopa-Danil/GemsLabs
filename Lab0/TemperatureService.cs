namespace Lab0
{
    public class TemperatureService
    {
        public static string ConvertTemperature(int temperature, string scaleOfTemperature)
        {
            scaleOfTemperature = scaleOfTemperature.ToLower();
            if (scaleOfTemperature.Equals("c"))
                return $"{Math.Round(temperature * 9.0 / 5 + 32)}F";
            if (scaleOfTemperature.Equals("f"))
                return $"{Math.Round((temperature - 32) * 5 / 9.0)}C";
            throw new ArgumentException("scaleOfTemperature is not correct");
        }
    }
}