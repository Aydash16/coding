namespace first;

public static class Program
{
    public static void Main(string[] args)
    {
        string path = "C:/Users/gr622_orahe/Desktop/rkis/3 lab/input.txt";
        string path2 = "C:/Users/gr622_orahe/Desktop/rkis/3 lab/output.txt";

        using StreamReader reader = new StreamReader(path);
        using StreamWriter writer = new StreamWriter(path2);

        string s = reader.ReadLine();
        int[] nums = s.Split(" ").Select(int.Parse).ToArray();

        int n = Convert.ToInt32(reader.ReadLine());

        string[] tickets = new string[n];

        for (int i = 0; i < n; i++)
        {
            tickets[i] = reader.ReadLine();
        }

        foreach (string str in tickets)
        {
            int[] ticket = str.Split(" ").Select(int.Parse).ToArray();

            int c = 0;

            for (int i = 0; i < ticket.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (ticket[i] == nums[j])
                        c++;
                }
            }
            if (c >= 3)
                writer.WriteLine("Lucky");
            else
                writer.WriteLine("Unlucky");
        }

        reader.Close();
        writer.Close();
    }
}