using System;

namespace third
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string path = "C:/Users/gr622_orahe/Desktop/rkis/5 labs/numsTask3.txt";
            string path = "C:/Users/Sayan/Desktop/rkis-master/5 labs/numsTask3.txt";
            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();

            int[] nums = str.Split(' ').Select(int.Parse).ToArray();

            int min = nums[0], min_i = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    min_i = i;
                }
            }

            int sum = 0;

            for (int i = 0; i < min_i; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine( (float)sum / (float)min_i - 1);

            reader.Close();
        }
    }
}
