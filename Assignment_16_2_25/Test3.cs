using System;
using System.Text;

class Test3
{
    public static void Print()
    {
        string[] words = { "Hello", " ", "World", "!", " Welcome", " to", " C#." };

        string result = ConcatenateStrings(words);
        Console.WriteLine("Concatenated String: " + result);
    }

    static string ConcatenateStrings(string[] strings)
    {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strings)
        {
            sb.Append(str);
        }

        return sb.ToString();
    }
}