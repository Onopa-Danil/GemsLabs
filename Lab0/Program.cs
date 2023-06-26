namespace Lab0
{
    public class Program
    {
        public static void Main()
        {
            string? input;
            do
            {
                Console.Clear();
                Console.Write("Введите год: ");
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input));
            
            int year;
            try
            {
                year = int.Parse(input);
                Console.WriteLine($"{year} - {(YearService.IsItLeapYear(year) ? "" : "не")}високосный год");
            }
            catch (FormatException err)
            {
                Console.WriteLine("Введен текст, а не число");
                return;
            }
            catch (ArgumentException err)
            {
                Console.WriteLine("Год < 0");
                return;
            }

            Console.ReadKey();
            string? temperature;
            string? scaleOfTemperature;
            do
            {
                Console.Clear();
                Console.Write("Введите значение температуры: ");
                temperature = Console.ReadLine();
                Console.Write("Введите значение шкалы: ");
                scaleOfTemperature = Console.ReadLine();
            } while (string.IsNullOrEmpty(temperature) || string.IsNullOrEmpty(scaleOfTemperature));

            try
            {
                Console.WriteLine
                    ("Результат: " + 
                     TemperatureService.ConvertTemperature(int.Parse(temperature), scaleOfTemperature));
            }
            catch (FormatException err)
            {
                Console.WriteLine("Введен текст, а не число");
            }
            catch (ArgumentException err)
            {
                Console.WriteLine("Введена неверная температурная шкала");
            }
        }
    }
}