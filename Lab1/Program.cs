namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            string maximumWord = string.Empty;
            StringService.SetMaxLengthStr(ref maximumWord);
            if ("".Equals(maximumWord)) Console.WriteLine("\nСлово не было введено");
            else Console.WriteLine
                ($"\nСчитывание завершено.\nСамое длинное слово: \"{maximumWord.ToUpper()}\" ({maximumWord.Length}).");
            
            
            Console.ReadKey();
            Console.Clear();

            int countOfSuccessfulThrows;
            int result;
            CoinTossGame.StartGame(out countOfSuccessfulThrows, out result);
            Console.WriteLine($"Игра окончена со счетом {countOfSuccessfulThrows}, угадано {result}% бросков.");
        }
    }
}