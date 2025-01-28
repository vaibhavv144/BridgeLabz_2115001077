// Question9.cs
using System;

class Ques9
{
    public void CheckNumberProperties()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check properties of each number
        foreach (int number in numbers)
        {
            if (IsPositive(number))
            {
                Console.WriteLine($"{number} is positive and {(IsEven(number) ? "even" : "odd")}.");
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
            }
        }

        // Compare the first and last elements of the array
        int comparison = Compare(numbers[0], numbers[^1]);
        if (comparison == 0)
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (comparison > 0)
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }

    private bool IsPositive(int number)
    {
        return number > 0;
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 < number2)
            return -1;
        else
            return 0;
    }
}