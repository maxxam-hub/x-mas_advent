using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string? inputLine;
        double k = 0;
        HashSet<double> set = new HashSet<double>();

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            addToSet(inputLine, ref set);
        }
        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            countFresh(inputLine, ref set, ref k);
        }
        Console.WriteLine(k);
    }

    static void addToSet(string str, ref HashSet<double> set)
    {
        string[] se = str.Split("-");
        double start = Convert.ToInt64(se[0]), end = Convert.ToInt64(se[1]);
        for (double i = start; i < end + 1; i++)
        {
            set.Add(i);
        }
    }

    static void countFresh(string str, ref HashSet<double> set, ref double k)
    {
        if (set.Contains(Convert.ToInt64(str))) k++;
    }
}