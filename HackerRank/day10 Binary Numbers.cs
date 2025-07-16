using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution10
{
        public static void day10(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()?.Trim());

        string binaryStr = Convert.ToString(n, 2);

        int maxCount = 0, currentCount = 0;
        foreach (char c in binaryStr)
        {
            if (c == '1')
            {
                currentCount++;
                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            else
            {
                currentCount = 0;
            }
        }

        Console.WriteLine(maxCount);
    }

}


// 5
// Output: 1
// The binary representation of 5 is 101, which has a maximum consecutive ones count of 1.