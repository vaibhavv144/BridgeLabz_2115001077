using System;

namespace NumberUtilsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberUtils numberUtils = new NumberUtils();

            int[] numbers = { 2, 4, 6, 7, 9 };
            foreach (var number in numbers)
            {
                bool isEven = numberUtils.IsEven(number);
                Console.WriteLine($"Is {number} even? {isEven}");
            }
        }
    }
}