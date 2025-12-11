using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string? inputLine;
        double sum = 0;
        int height = 0, width = 0, res = 0;
        List<string> arrayString = new List<string>();

        while (!string.IsNullOrEmpty(inputLine = Console.ReadLine()))
        {
            arrayString.Add(inputLine);
            width = inputLine.Length;
        }
        height = arrayString.Count;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (arrayString[i][j] == '@')
                {
                    if (CountAround(ref arrayString, i, j, height, width) < 4)
                    {
                        res += 1;
                    }
                }
            }
        }
        Console.WriteLine(res);
    }

    static int CountAround(ref List<string> arrayOfRows, int i, int j, int height, int width)
    {
        int c = 0;
        for (int k = -1; k < 2; k++)
        {
            for (int l = -1; l < 2; l++)
            {
                if (k + i > 0 && k + i < height && l + j > 0 && l + j < width)
                {
                    if (arrayOfRows[i + k][j + l] == '@') c += 1;
                }
            }
        }
        return c - 1;
    }
}