using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main()
    {
        int k = 0, curK = 0, temp = 0, current = 50;
        string rotation = "";

        while (isEnd(ref rotation))
        {
            temp = int.Parse(rotation.Substring(1));

            if (rotation[0] == 'R')
            {
                curK = (temp + current) / 100;
                current = (current + temp) % 100;
            }
            if (rotation[0] == 'L')
            {
                curK = current > temp ? 0 : (current - temp - 100) / -100;
                current = curK == 0 ? (current - temp + 100) % 100 : (current - temp + 100 * curK) % 100;
            }

            k += curK;

            Console.WriteLine($"{k} {current}");
        }
    }

    static bool isEnd(ref string str)
    {
        str = Console.ReadLine();

        if (str == "" || str == "\n" || str == " ") return false;
        else return true;
    }
}