namespace second;

public static class Program
{
    public static void Main(string[] args)
    {
        string path = "C:\\Users\\gr622_orahe\\Desktop\\rkis\\3 lab\\file.txt";

        using StreamReader reader = new StreamReader(path);

        string s = reader.ReadToEnd();

        reader.Close();

        using StreamWriter writer = new StreamWriter(path);

        int[] nums = s.Split(' ').Select(int.Parse).ToArray();

        writer.Write(string.Empty);

        foreach (int i in nums)
        {
            if (i % 2 != 0)
            {
                writer.Write(i + " ");
            }
        }

        writer.Close();

    }
}