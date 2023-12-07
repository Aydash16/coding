namespace second_task;

public class Program
{
    public static int[] FillArray(int[] array, int n)
    {
        Random rnd = new Random();

        array[0] = 1;

        for (int i = 1; i < n; i++)
        {
            array[i] = array[i - 1] + 2;
        }

        return array;
    }

    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] nums = new int[n];

        FillArray(nums, n);

        for (int i = 0; i < n; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}