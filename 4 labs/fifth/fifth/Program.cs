namespace labs;

public static class FileName
{
    public static void Main(string[] args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
            Console.WriteLine("The point is inside of the square.");
        else
            Console.WriteLine("The point is outside of the square.");
    }
}