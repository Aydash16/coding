namespace third_task;

public class Program
{
    public static int[,] FillArray(int[,] array, int n)
    {

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || i == 0)
                {
                    array[i, j] = 1;
                }
                else
                    array[i, j] = array[i - 1, j] + array[i, j - 1];
            }
        }

        return array;
    }

    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        FillArray(matrix, n);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }
}