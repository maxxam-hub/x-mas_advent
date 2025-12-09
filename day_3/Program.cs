using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string? inputLine;
        int sum = 0;
        List<string> arrayOfRows = new List<string>();

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            arrayOfRows.Add(inputLine);
        }
        foreach (var e in arrayOfRows)
        {
            sumJoltage(e, ref sum);
        }
        Console.WriteLine(sum);
    }

    static void sumJoltage(string str, ref int sum)
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
        Console.WriteLine($"maxone: {Convert.ToString(maxOne)} maxtwo {Convert.ToString(maxTwo)}");
        sum += int.Parse(Convert.ToString(maxOne) + Convert.ToString(maxTwo));
    }
}