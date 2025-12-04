using System;
using System.IO;

class Program
{
    static void Main()
    {
        long totalHits = 0;
        int pos = 50;

        foreach (var line in File.ReadAllLines("input.txt"))
        {
            char dir = line[0];
            long steps = long.Parse(line.Substring(1));

            int dirSign = dir == 'R' ? 1 : -1;

            long k_first;
            if (dir == 'R')
            {
                k_first = (100 - pos) % 100;
                if (k_first == 0) k_first = 100;
            }
            else
            {
                k_first = pos % 100;
                if (k_first == 0) k_first = 100;
            }

            if (steps >= k_first)
                totalHits += 1 + (steps - k_first) / 100;

            pos = (int)((pos + dirSign * steps) % 100);
            if (pos < 0) pos += 100;
        }

        Console.WriteLine(totalHits);
    }
}