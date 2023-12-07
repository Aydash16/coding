using System;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> strings = new List<string>();

        string str;
        int i = 0;

        do
        {
            str = Console.ReadLine();
            strings.Insert(i, str);
            i++;
        } while (str != "");
    }
}