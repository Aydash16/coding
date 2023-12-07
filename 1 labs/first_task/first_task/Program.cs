namespace first_task;

public class Program
{
    public static int FindMin(float[] array)
    {
        float min = array[0];
        int min_i = 0;

        for (int i = 1; i < 10; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                min_i = i;
            }
        }
        return min_i;
    }

    public static void Main(string[] args)
    {
        Random rand = new Random();
        
        float[] nums = new float[10];

        for (int i = 0; i < 10; i++)
        {
            nums[i] = rand.Next(-100, 100);
            Console.Write(nums[i] + " ");
        }

        int min_i = FindMin(nums);

        Console.WriteLine("\nMinimum number index in array is " + min_i);
    }
}