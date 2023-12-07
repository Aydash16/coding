namespace second_task;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int num, i = 0;

        do
        {
            num = Int32.Parse(Console.ReadLine());
            numbers.Insert(i, num);
            i++;
        } while (num != 0);
    }
}