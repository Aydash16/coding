namespace first;

public static class Program
{
    public static void Main()
    {
        string path = "C:/Users/gr622_orahe/Desktop/rkis/5 labs/numsTask1.txt";
        using StreamReader reader = new StreamReader(path);

        string str = reader.ReadToEnd();

        int[] nums = str.Split(' ').Select(int.Parse).ToArray();

        int min = nums[0], min_i = 0, p = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                min_i = i;
            }
        }

        for (int i = min_i + 1; i < nums.Length; i++)
        {
            p *= nums[i];
        }

        Console.WriteLine(p);
        
        reader.Close();
    }
}