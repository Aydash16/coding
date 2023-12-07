namespace third;

public static class FileName
{
    public static void Main(string[] args)
    {
        string path = "C:/Users/gr622_orahe/Desktop/rkis/3 lab/3-input.txt";
        using StreamReader reader = new StreamReader(path);

        string nums = reader.ReadLine();
        int[] height = nums.Split(' ', '\0').Select(int.Parse).ToArray();
        int i = height.Length;

        int max = 0;

        for (int j = 0; j < i - 1; j++)
        {
            for (int k = j + 1; k < i; k++)
            {
                int S = Math.Min(height[j], height[k]) * (k - j);
                if (S > max)
                    max = S;
            }
        }
        Console.WriteLine(max);

        reader.Close();
    }
}