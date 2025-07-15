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



class Solution05
{
    public static void day05(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 1; i < 11; i++)
        {
            int s = i * n;
            Console.WriteLine(n + " x " + i + " = " + s);
        }
    }
}


// 3