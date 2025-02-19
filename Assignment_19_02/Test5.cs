using System;
using System.Collections.Generic;

class Test5
{
    public static string FindNthFromEnd(LinkedList<string> list, int N)
    {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        // Move `first` N steps ahead
        for (int i = 0; i < N; i++)
        {
            if (first == null)
                throw new ArgumentException("N is greater than the number of elements in the list.");
            first = first.Next;
        }

        // Move both pointers until `first` reaches the end
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return second.Value; // `second` now points to the Nth node from the end
    }

    public static void Print()
    {
        LinkedList<string> list = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        int N = 2;

        string result = FindNthFromEnd(list, N);
        Console.WriteLine($"Nth element from the end: {result}");
    }
}
