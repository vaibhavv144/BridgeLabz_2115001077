using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Test14
{
    public static Dictionary<string, int> CountWordFrequency(string filePath)
    {
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string text = File.ReadAllText(filePath).ToLower();
        string[] words = Regex.Split(text, @"\W+");

        foreach (var word in words)
        {
            if (string.IsNullOrWhiteSpace(word))
                continue;

            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency[word] = 1;
            }
        }

        return wordFrequency;
    }

   public  static void Print()
    {
        string filePath = "path/to/your/textfile.txt";
        Dictionary<string, int> frequency = CountWordFrequency(filePath);
        foreach (var kvp in frequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
