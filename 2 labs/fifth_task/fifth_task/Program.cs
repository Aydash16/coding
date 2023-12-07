namespace fifth_task;

public class Program
{
    public static Dictionary<string, int> temperature()
    {
        Dictionary<string, int> temperature = new Dictionary<string, int>();
        string[] months =
        {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        int[] arr = new int[30];
        int average = 0;

        Random rnd = new Random();

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                arr[j] = rnd.Next(-30, 40);
                average += arr[j];
            }
            temperature.Add(months[i], average / 30);
            average = 0;
        }

        return temperature;
    }

    public static void Main(string[] args)
    {
        Dictionary<string, int> temp = temperature();

        foreach (var monthTemp in temp)
        {
            Console.WriteLine(monthTemp.Key + ": " + monthTemp.Value);
        }
    }
}