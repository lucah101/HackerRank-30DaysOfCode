using System;
using System.Collections.Generic;
using System.IO;
class Solution08
{
    static void day08(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string name = input.Split(' ')[0];
            string number = input.Split(' ')[1];
            phoneBook[name] = number;
        }
        string findName;
        while ((findName = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(findName))
            {
                Console.WriteLine(findName + "=" + phoneBook[findName]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}


// 3
// sam 99912222
// tom 11122222
// harry 12299933
// sam
// edward
// harry