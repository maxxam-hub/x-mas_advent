using System;
using System.IO;

class Program
{
    static void Main()
    {
        string? inputLine;
        string res = "";
        double sum = 0;

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            res += inputLine;
        }
        var arrayOfRows = res.Split(",");
        foreach (var e in arrayOfRows)
        {
            sumRes(e, ref sum);
        }
        Console.WriteLine(sum);
    }

    static void sumRes(string row, ref double sum)
    {
        var arr = row.Split("-");
        var start = double.Parse(arr[0]);
        var end = double.Parse(arr[1]);
        string str = "";
        for (double i = start; i < end + 1; i++)
        {
            str = Convert.ToString(i);
            if (str.Length % 2 == 0)
            {
                var half = str.Length / 2;
                var firstHalf = str.Substring(0, half);
                var secondHalf = str.Substring(half);
                Console.WriteLine($"srt: {str} Parts: {firstHalf} - {secondHalf}");
                if (firstHalf == secondHalf)
                {
                    sum += Convert.ToInt64(str);
                    Console.WriteLine($"{str} - {sum}");
                }
            }
        }
    }
}