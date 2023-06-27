namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            string currentWord = string.Empty;
            string maximumWord = string.Empty;
            Console.WriteLine("Вводите слова, завершая каждое нажатием Enter.");
            Console.WriteLine("Для выхода наберите \"exit\".\n");
            do
            {
                if (currentWord.Length > maximumWord.Length) maximumWord = currentWord;
                currentWord = Console.ReadLine() ?? string.Empty;
            } while (!"exit".Equals(currentWord));
            if ("".Equals(maximumWord)) Console.WriteLine("\nСлово не было введено");
            else Console.WriteLine
                ($"\nСчитывание завершено.\nСамое длинное слово: \"{maximumWord.ToUpper()}\" ({maximumWord.Length}).");
            
            
            Console.ReadKey();
            Console.Clear();

            int countOfSuccessfulThrows = 0;
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

            int result = countOfThrows == 0 ? 0 : (int)(countOfSuccessfulThrows / (double)countOfThrows * 100);
            Console.WriteLine($"Игра окончена со счетом {countOfSuccessfulThrows}, угадано {result}% бросков.");
        }
    }
}