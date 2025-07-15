using System;
using System.Collections.Generic;
using System.IO;

class Solution01
{
    static void day01(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Read and save an integer, double, and String to your variables.
        int readI = Convert.ToInt32(Console.ReadLine());
        double readD = Convert.ToDouble(Console.ReadLine());
        string readS = Console.ReadLine() ?? "";

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + readI);

        // Print the sum of the double variables on a new line.
        double sum = d + readD;
        Console.WriteLine(sum.ToString("F1"));

        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + readS);

    }
}