using System;

namespace fourth
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string path = "C:/Users/gr622_orahe/Desktop/rkis/5 labs/numsTask5.txt";
            string path = "C:/Users/Sayan/Desktop/rkis-master/5 labs/numsTask5.txt";
            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();

            int[] nums = str.Split(' ').Select(int.Parse).ToArray();

            int max = nums[0], min = nums[0], min_i = 0, max_i = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    max_i = i;
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                    min_i = i;
                }
            }

            int sum = 0;

            for (int i = min_i + 1; i < max_i; i++)
            {
                    sum += nums[i];
            }

            Console.WriteLine((float)sum / (float)(max_i - min_i - 1));

            reader.Close();
        }
    }
}