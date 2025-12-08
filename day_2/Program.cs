using System;
using System.IO;
using System.Text.RegularExpressions;

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
            sumResSecond(e, ref sum);
        }
        Console.WriteLine(sum);
    }

    static void sumResOne(string row, ref double sum)
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

    static void sumResSecond(string row, ref double sum)
    {
        var arr = row.Split("-");
        var start = double.Parse(arr[0]);
        var end = double.Parse(arr[1]);
        string str = "", tempStr = "";
        int matches = 0;
        bool flagContinue = true;
        for (double i = start; i < end + 1; i++)
        {
            str = Convert.ToString(i);
            for (int j = 0; j < str.Length; j++)
            {
                tempStr = str.Substring(0, j + 1);
                matches = Regex.Matches(str, tempStr).Count;
                if (matches >= 2 && flagContinue && (matches * tempStr.Length == str.Length))
                {
                    sum += Convert.ToInt64(str);
                    Console.WriteLine($"srt: {str} tempStr {tempStr} sum: {sum}");
                    flagContinue = false;
                }
            }
            flagContinue = true;
        }
    }
}