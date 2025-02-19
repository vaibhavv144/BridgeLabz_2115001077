using System;
using System.Collections.Generic;

class Test12
{
   public static void Print()
    {
        int N = 5;
        List<string> binaryNumbers = GenerateBinaryNumbers(N);

        Console.WriteLine("Binary Numbers: " + string.Join(", ", binaryNumbers));
    }

    static List<string> GenerateBinaryNumbers(int N)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("1"); // Start with "1"

        for (int i = 0; i < N; i++)
        {
            string front = queue.Dequeue();
            result.Add(front);

            // Generate next two binary numbers
            queue.Enqueue(front + "0");
            queue.Enqueue(front + "1");
        }

        return result;
    }
}
