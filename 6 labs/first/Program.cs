using System;

namespace first
{
    public class Program
    {
        public static void Main()
        {
            //string path = "C:/Users/gr622_orahe/Desktop/rkis/6 labs/numsTask1.txt";
            string path = "C:/Users/Sayan/Desktop/rkis-master/6 labs/numsTask1.txt";
            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadToEnd();
            string[] strs = str.Split(' ');

            foreach (string word in strs)
            {
                if (word.Length % 2 != 0)
                    Console.WriteLine(word);
            }

            reader.Close();
        }
    }
}
