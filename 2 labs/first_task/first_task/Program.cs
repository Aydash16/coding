namespace first_task;

public class Program
{
    public static int[] FillArray(int[] array)
    {
        Random rnd = new Random();

        array[0] = rnd.Next(0, 1000);

        for (int i = 1; i < 100; i++)
        {
            array[i] = array[i - 1] - 3;
        }

        return array;
    }

    public static void Main(string[] args)
    {
        int[] nums = new int[100];

        FillArray(nums);

        for (int i = 0; i < 100; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}