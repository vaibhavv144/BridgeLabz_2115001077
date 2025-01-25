using System;

public class Ques2
{
    public static void AnalyzeNumberArray()
    {
        // Initialize an array to store 5 numbers
        int[] numbers = new int[5];
        
        // Loop to input numbers into the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Enter the number for position {i + 1}:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            
            // Store the input number in the array
            numbers[i] = inputNumber;
        }

        // Loop to analyze each number in the array
        for (int index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] > 0) // Check if the number is positive
            {
                if (numbers[index] % 2 == 0) // Check if the number is even
                {
                    Console.WriteLine($"The number {numbers[index]} is even.");
                }
                else // If not even, it is odd
                {
                    Console.WriteLine($"The number {numbers[index]} is odd.");
                }
            }
            else if (numbers[index] == 0) // Check if the number is zero
            {
                Console.WriteLine($"The number {numbers[index]} is zero.");
            }
            else // If not positive or zero, it is negative
            {
                Console.WriteLine($"The number {numbers[index]} is negative.");
            }
        }

        // Compare the first and last numbers in the array
        if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first number is greater than the last number.");
        }
        else if (numbers[0] < numbers[numbers.Length - 1])
        {
            Console.WriteLine("The first number is smaller than the last number.");
        }
        else
        {
            Console.WriteLine("The first and last numbers are equal.");
        }
    }
}
