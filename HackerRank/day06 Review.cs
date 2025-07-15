using System;
using System.Collections.Generic;
using System.IO;
class Solution06
{
    static void day06(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = int.Parse(Console.ReadLine());
        String[] s = new string[t];
        for (int i = 0; i < t; i++)
        {
            s[i] = Console.ReadLine();
        }
        for (int i = 0; i < t; i++)
        {
            string str = s[i];
            for (int j = 0; j < str.Length; j = j + 2)
            {
                Console.Write(str[j]);
            }
            Console.Write(" ");
            for (int k = 1; k < str.Length; k = k + 2)
            {
                Console.Write(str[k]);
            }
            Console.WriteLine();
        }
    }
}

// 2
// Hacker
// Rank