namespace Lab1;

public class CoinTossGame
{
    public static void StartGame(out int countOfSuccessfulThrows, out int result)
    {
        countOfSuccessfulThrows = 0;
        int countOfThrows = 0;
        try
        {
            Console.WriteLine("Игра началась!");
            Random random = new Random();
            int value;
            do
            {
                Console.Write("Введите число: ");
                value = int.Parse(Console.ReadLine() ?? string.Empty);
                if (value == 0 || value == 1)
                {
                    countOfThrows++;
                    if (value == random.Next(2))
                    {
                        countOfSuccessfulThrows++;
                        Console.WriteLine("Угадали!");
                    }
                    else Console.WriteLine("Попробуйте снова");
                }
            } while (value == 0 || value == 1);
        }
        catch(FormatException ignored){}

        result = countOfThrows == 0 ? 0 : (int)(countOfSuccessfulThrows / (double)countOfThrows * 100);
    }
}