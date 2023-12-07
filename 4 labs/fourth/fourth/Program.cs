namespace fourth;

public static class Program
{
    public static void Main()
    {
        //string path = "C:\\Users\\gr622_orahe\\Desktop\\rkis\\4 labs\\numsTask4.txt";
        string path = "C:\\Users\\Sayan\\Desktop\\rkis-master\\4 labs\\numsTask4.txt";
        using StreamReader reader = new StreamReader(path);

        string str = reader.ReadLine();
        int[] nums = str.Split(' ').Select(int.Parse).ToArray();

        int s = 0;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                s++;
            }
            else if (nums[i] == nums[i - 1])
            {
                s++;
            }
        }
        if (nums[0] == nums[1])
        {
            s++;
        }
        if (nums[nums.Length - 1] == nums[nums.Length - 2])
        {
            s++;
        }

        Console.WriteLine(s);
    }
}