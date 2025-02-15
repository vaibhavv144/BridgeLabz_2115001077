using System;
using System.Text;
using System.Collections.Generic;

class Test2
{
    public static void Print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicates(string str)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char c in str)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}