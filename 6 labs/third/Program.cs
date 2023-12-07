using System;

namespace third
{
    public class Program
    {
        public static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 10 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
