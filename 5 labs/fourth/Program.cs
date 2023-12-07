using System;

namespace fourth
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string path = "C:/Users/gr622_orahe/Desktop/rkis/5 labs/numsTask4.txt";
            string path = "C:/Users/Sayan/Desktop/rkis-master/5 labs/numsTask4.txt";
            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();

            int[] nums = str.Split(' ').Select(int.Parse).ToArray();

            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max - 1)
                    sum += nums[i];
            }

            Console.WriteLine(sum);

            reader.Close();
        }
    }
}