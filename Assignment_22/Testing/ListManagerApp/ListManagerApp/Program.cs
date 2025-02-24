using System;
using System.Collections.Generic;



namespace ListManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListManager listManager = new ListManager();
            List<int> numbers = new List<int> { 1, 2, 3 };

            listManager.AddElement(numbers, 4);
            Console.WriteLine("List after adding 4: " + string.Join(", ", numbers));

            listManager.RemoveElement(numbers, 2);
            Console.WriteLine("List after removing 2: " + string.Join(", ", numbers));

            int size = listManager.GetSize(numbers);
            Console.WriteLine("Size of the list: " + size);
        }
    }
}