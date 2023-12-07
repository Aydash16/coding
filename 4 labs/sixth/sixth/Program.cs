namespace labs;

public static class FileName
{
    public static void Main(string[] args)
    {
        const int S = 10;

        float x0 = float.Parse(Console.ReadLine());
        float y0 = float.Parse(Console.ReadLine());
        float x1 = 0;
        float y1 = 2;
        float x2 = 2;
        float y2 = -3;
        float x3 = -2;
        float y3 = -3;

        float a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
        float b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
        float c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

        if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
        {
            Console.WriteLine("The point is in the triangle");
        }
        else
        {
            Console.WriteLine("The point isn't in the triangle");
        }
    }
}
