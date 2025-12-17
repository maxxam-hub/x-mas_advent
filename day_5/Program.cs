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
        List<double> ingridients = new List<double>();

        while ((inputLine = Console.ReadLine()) != ' ')
        {
            addToSet(inputLine, ref set);
        }
        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            addToSet(inputLine, ref set);
        }
        Console.WriteLine(k);
    }

    static void addToSet(string str, ref HashSet<double> set)
    {
        double[] se = new double[str.Split("-")];
        double start = se[0], end = se[1];
        for (int i = start; i < end + 1; i++)
        {
            set.Add(i);
        }
    }

    static void countFresh(string str, ref HashSet<double> set)
    {
        double[] se = new double[str.Split("-")];
        double start = se[0], end = se[1];
        for (int i = start; i < end + 1; i++)
        {
            set.Add(i);
        }
    }
}