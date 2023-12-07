namespace fourth_task;

public class Program
{
    public static int[,] FillArray(int[,] array)
    {
        Random rnd = new Random();

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                array[i, j] = rnd.Next(-30, 40);
            }
        }

        return array;
    }

    public static void Main(string[] args)
    {
        int[,] temp = new int[12, 30];

        FillArray(temp);

        int average = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                average += temp[i, j];
            }
            Console.WriteLine(i + 1 + " months average temperature is about " + average / 30);
            average = 0;
        }
    }
}