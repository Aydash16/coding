namespace labs;

public static class FileName
{
    public static void Main(string[] args)
    {
        string path = "C:\\Users\\gr622_orahe\\Desktop\\rkis\\4 lab\\numsTask3.txt";
        using StreamReader reader = new StreamReader(path);

        string str = reader.ReadToEnd();
        int[] nums = str.Split(',').Select(int.Parse).ToArray();

        int min = nums[0], max = nums[0];

        foreach (int num in nums)
        {
            if (num == 0)
                break;

            if (num > max)
                max = num;
            else if (num < min)
                min = num;
        }

        Console.WriteLine(max - min);
        reader.Close();
    }
}