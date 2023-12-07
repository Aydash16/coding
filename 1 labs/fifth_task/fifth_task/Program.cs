namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();

        int spaces = 0;

        foreach (char ch in str)
        {
            if (ch == ' ')
                spaces++;
        }

        Console.WriteLine($"There are {spaces + 1} words in the string.");
        Console.WriteLine("Start" + str + "End");
    }
}