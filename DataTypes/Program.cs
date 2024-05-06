using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int x;
        double y;
        string z;

        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        z = Console.ReadLine();

        // Print a string literal saying "Hello, World." to stdout using cout.
        Console.WriteLine(x + i);
        Console.WriteLine((d + y).ToString("F1"));
        Console.WriteLine(string.Concat(s, z));

    }
}