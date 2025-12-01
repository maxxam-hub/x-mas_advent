using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main()
    {
        int k = 0;
        int current = 50;
        string rotation = "";

        while (isEnd(ref rotation))
        {
            if (rotation[0] == 'R')
            {
                current = (current + int.Parse(rotation.Substring(1))) % 100;
                k = current == 0 ? k + 1 : k;
            }
            if (rotation[0] == 'L')
            {
                current = (current - int.Parse(rotation.Substring(1)) + 100) % 100;
                k = current == 0 ? k + 1 : k;
            }
        }

        Console.WriteLine(k);
    }

    static bool isEnd(ref string str)
    {
        str = Console.ReadLine();

        if (str == "" || str == "\n" || str == " ") return false;
        else return true;
    }
}