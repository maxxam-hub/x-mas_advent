using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string? inputLine;
        double k = 0, size = 0;
        List<(double, double)> listOfTuples = new List<(double, double)>();
        List<(double, double)> merged = new List<(double, double)>();
        List<double> listOfDouble = new List<double>();

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            addToList(inputLine, ref listOfTuples, ref size);
        }
        unionIntervals(ref merged, listOfTuples, size);
        foreach (var r in merged)
        {
            k += (r.Item2 - r.Item1 + 1);
        }
        Console.WriteLine(k);
    }

    static void addToList(string str, ref List<(double, double)> list, ref double size)
    {
        string[] se = str.Split("-");
        double start = Convert.ToInt64(se[0]), end = Convert.ToInt64(se[1]);
        list.Add((start, end));
        size++;
    }

    static void unionIntervals(ref List<(double, double)> merged, List<(double, double)> list, double size)
    {
        list.Sort((x, y) => x.Item1.CompareTo(y.Item1));
        var current = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i].Item1 <= current.Item2 + 1) current = (current.Item1, Math.Max(current.Item2, list[i].Item2));
            else
            {
                merged.Add(current);
                current = list[i];
            }
        }
        merged.Add(current);
    }

    static void countFresh(string str, List<(double, double)> list, ref double k, double size)
    {
        double n = Convert.ToInt64(str);
        for (int i = 0; i < size; i++)
        {
            if (n <= list[i].Item2 && n >= list[i].Item1)
            {
                Console.WriteLine($"I1 {list[i].Item1} I2 {list[i].Item2} n {n}");
                k++;
                break;
            }
        }
    }
}