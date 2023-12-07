namespace first;

public static class FileName
{
    public static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                p *= i;
            }
        }
        Console.WriteLine(p);
    }
}