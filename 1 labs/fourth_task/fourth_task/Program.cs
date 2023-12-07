namespace fourth_task;

public class Program
{
    public static int[] FillArray(int[] array, int n, int start, int end)
    {
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.Next(start, end);
        }

        return array;
    }

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        FillArray(nums, n, start, end);

        for (int i = 0; i < n; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}