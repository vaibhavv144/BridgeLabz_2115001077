using System;
using System.Collections.Generic;

class Test4
{
    public static List<int> RemoveDuplicates(List<int> nums)
    {
        HashSet<int> seen = new HashSet<int>(); // To track unique elements
        List<int> result = new List<int>();     // To store elements in order

        foreach (int num in nums)
        {
            if (!seen.Contains(num)) // Add only if not seen before
            {
                seen.Add(num);
                result.Add(num);
            }
        }

        return result;
    }

    public static void Print()
    {
        List<int> nums = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> uniqueList = RemoveDuplicates(nums);

        Console.WriteLine("List after removing duplicates: " + string.Join(", ", uniqueList));
    }
}
