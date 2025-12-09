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

    static void sumJoltageTwo(string str, ref double sum)
    {
        int convertChar = 0, max = -1, indexOfMax = 0;
        string resStr = "", tempStr = str;
        while (resStr.Length != 12)
        {
            if (tempStr.Length > 12)
            {
                for (int i = 0; i < tempStr.Length - 12; i++)
                {
                    convertChar = int.Parse(tempStr[i].ToString());
                    if (convertChar > max)
                    {
                        max = convertChar;
                        indexOfMax = i;
                    }
                }
                resStr += Convert.ToString(max);
                max = -1;
                tempStr = tempStr.Substring(indexOfMax);
            }
            else
            {
                resStr += tempStr;
            }
        }
        Console.WriteLine($"{resStr}");
        sum += Convert.ToInt64(resStr);
    }
}