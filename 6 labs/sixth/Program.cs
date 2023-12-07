using System;

namespace sixth
{
    public class Program
    {
        public static void Main()
        {
            Random rnd = new Random();

            int n = rnd.Next(1, 20);

            float[] nums = new float[n];
            float[] posNums = new float[n];
            float[] negNums = new float[n];
            int c = 0, d = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i] = (float)rnd.NextDouble() * 200 - 100;
                Console.Write(nums[i] + " ");
                if (nums[i] >= 0)
                {
                    posNums[c] = nums[i];
                    c++;
                }
                else
                    {
                        negNums[d] = nums[i];
                        d++;
                    }
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < c; i++)
            {
                Console.Write(posNums[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < d; i++)
            {
                Console.Write(negNums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
