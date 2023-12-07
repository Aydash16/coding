namespace second;

public static class Program
{
    public static void Main(string[] args)
    {
        string path = "C:\\Users\\gr622_orahe\\Desktop\\rkis\\4 lab\\numsTask2.txt";
        using StreamReader reader = new StreamReader(path);

        string str = reader.ReadToEnd();
        string[] strs = str.Split(';', ' ', '\0');

        double[] nums = Array.ConvertAll(strs, double.Parse);

        double sum = 0;
        int i = 0;

        while(nums[i] != 0) 
        { 
            if (nums[i] > 0)
                sum += nums[i];
            i++;
        }

        Console.WriteLine("The sum of positive numbers before first zero is " + sum);

        reader.Close();
    }
}