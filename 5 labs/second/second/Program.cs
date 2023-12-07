namespace first;

public static class Program
{
    public static void Main()
    {
        //string path = "C:/Users/gr622_orahe/Desktop/rkis/5 labs/numsTask2.txt";
        string path = "C:/Users/Sayan/Desktop/rkis-master/5 labs/numsTask2.txt";
        using StreamReader reader = new StreamReader(path);

        string str = reader.ReadToEnd();

        double[] nums = str.Split(';').Select(double.Parse).ToArray();

        reader.Close();

        using StreamWriter writer = new StreamWriter(path);

        writer.Write(String.Empty);

        double temp = 0;

        for (int i = 0; i < nums.Length; i++)
        {
             for (int j = 0; j < nums.Length - 1; j++)
            {
                if(nums[j] > nums[j + 1])
                {
                    temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums.Length - 1)
                writer.Write(nums[i] + ";");
            else
                writer.Write(nums[i]);
        }
        writer.Close();
    }
}