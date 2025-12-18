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

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            addToList(inputLine, ref listOfTuples, ref size);
        }
        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            countFresh(inputLine, listOfTuples, ref k, size);
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