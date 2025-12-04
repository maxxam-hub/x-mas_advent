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
                if (current - temp > 0) curK = 0;
                else if (current == temp) curK = 1;
                else
                {
                    curK = ((current - temp) / -100) < 1 ? 1 : ((current - temp) / -100 + 1);
                    if (current == 0 && temp < 100) curK = 0;
                }
                if (curK == 0)
                {
                    if (current == 0) current = temp - current;
                    else current = current - temp;
                }
                else current = (current - temp + 100 * curK) % 100;
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