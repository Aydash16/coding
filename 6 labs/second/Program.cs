using System;

namespace second
{
    public class Program
    {
        public static void Main()
        {
            string path = "C:\\Users\\Sayan\\Desktop\\rkis-master\\6 labs\\numsTask2.txt";
            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadLine();

            while(str != null)
            {
                Console.Write(str + ' ');
                str = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
