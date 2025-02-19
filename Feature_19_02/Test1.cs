using System;
using System.Collections;
using System.Collections.Generic;

class Test1
{
    // Reverse an ArrayList
    public static void ReverseArrayList(ArrayList list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            // Swap elements
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;

            left++;
            right--;
        }
    }

    // Reverse a LinkedList
    public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (var item in list)
        {
            reversedList.AddFirst(item); // Insert at front to reverse
        }
        return reversedList;
    }

    public static void Print()
    {
        // ArrayList Example
        ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original ArrayList: " + string.Join(", ", arrayList.ToArray()));
        ReverseArrayList(arrayList);
        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrayList.ToArray()));

        // LinkedList Example
        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("\nOriginal LinkedList: " + string.Join(", ", linkedList));
        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
        Console.WriteLine("Reversed LinkedList: " + string.Join(", ", reversedLinkedList));
    }
}
