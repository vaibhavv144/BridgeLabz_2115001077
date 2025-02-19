using System;
using System.Collections.Generic;

class Test9
{
    public static void Print()
    {
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
        List<int> sortedList = ConvertToSortedList(set);

        Console.WriteLine("Sorted List: [" + string.Join(", ", sortedList) + "]");
    }

    static List<int> ConvertToSortedList(HashSet<int> set)
    {
        List<int> sortedList = new List<int>(set);
        sortedList.Sort(); // Sorts in ascending order
        return sortedList;
    }
}
