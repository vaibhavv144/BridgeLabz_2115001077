using System;
using System.Collections.Generic;

class Test2
{
    public static Dictionary<string, int> CountFrequency(List<string> items)
    {
        Dictionary<string, int> frequencyDict = new Dictionary<string, int>();

        foreach (var item in items)
        {
            if (frequencyDict.ContainsKey(item))
                frequencyDict[item]++;
            else
                frequencyDict[item] = 1;
        }

        return frequencyDict;
    }

    public static void Print()
    {
        List<string> inputList = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> result = CountFrequency(inputList);

        Console.WriteLine("Element Frequencies:");
        foreach (var pair in result)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
