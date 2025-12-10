using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string? inputLine;
        double sum = 0;
        List<string> arrayOfRows = new List<string>();

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            arrayOfRows.Add(inputLine);
        }
        foreach (var e in arrayOfRows)
        {
            sumJoltageTwo(e, ref sum);
        }
        Console.WriteLine(sum);
    }

    static void sumJoltageOne(string str, ref int sum)
    {
        int maxOne = -1, maxTwo = -1;
        int convertCharOne = 0, convertCharTwo = 0, indexOfMax = 0;
        for (int i = 0; i < str.Length - 1; i++)
        {
            convertCharOne = int.Parse(str[i].ToString());
            if (convertCharOne > maxOne)
            {
                maxOne = convertCharOne;
                indexOfMax = i;
            }
        }
        for (int j = indexOfMax + 1; j < str.Length; j++)
        {
            convertCharTwo = int.Parse(str[j].ToString());
            if (convertCharTwo > maxTwo)
            {
                maxTwo = convertCharTwo;
            }
        }
        sum += int.Parse(Convert.ToString(maxOne) + Convert.ToString(maxTwo));
    }

    public static void sumJoltageTwo(string line, ref double sum)
    {
        const int digitsToTake = 12;
        int n = line.Length;

        char[] result = new char[digitsToTake];

        int startIndex = 0;

        for (int pos = 0; pos < digitsToTake; pos++)
        {
            char maxDigit = '0';
            int maxIndex = startIndex;

            int endIndex = n - (digitsToTake - pos);

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (line[i] > maxDigit)
                {
                    maxDigit = line[i];
                    maxIndex = i;
                }
            }

            result[pos] = maxDigit;
            startIndex = maxIndex + 1;
        }

        sum += Convert.ToInt64(new string(result));
    }
}