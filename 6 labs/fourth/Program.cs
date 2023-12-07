using System;

namespace fourth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int num = 0, sum = 0;

            while (num >= 0)
            {
                num = int.Parse(Console.ReadLine());
                if (num % a == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);     
        }
    }
}
