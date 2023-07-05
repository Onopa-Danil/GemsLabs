namespace Lab1;

public class StringService
{
    public static void SetMaxLengthStr(ref string result)
    {
        Console.WriteLine("Вводите слова, завершая каждое нажатием Enter.");
        Console.WriteLine("Для выхода наберите \"exit\".\n");
        string currentWord = string.Empty;
        do
        {
            if (currentWord.Length > result.Length) result = currentWord;
            currentWord = Console.ReadLine() ?? string.Empty;
        } while (!"exit".Equals(currentWord));
    }
}