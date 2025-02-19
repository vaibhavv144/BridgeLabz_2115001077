using System;
using System.Collections.Generic;

class Test11
{
   public static void Print()
    {
        Queue<int> queue = new Queue<int>(new[] { 10, 20, 30 });

        Console.WriteLine("Original Queue: " + string.Join(", ", queue));
        Queue<int> reversedQueue = ReverseQueue(queue);
        Console.WriteLine("Reversed Queue: " + string.Join(", ", reversedQueue));
    }

    static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        // Dequeue elements and push them onto the stack
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        // Pop elements from the stack and enqueue back into the queue
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
}
