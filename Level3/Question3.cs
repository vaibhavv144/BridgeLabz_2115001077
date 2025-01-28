// Question3.cs
using System;

class Question3
{
    public void NumberCheckerTasks2()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);
        int sumOfDigits = SumOfDigits(digits);
        int sumOfSquares = SumOfSquares(digits);
        bool isHarshad = IsHarshadNumber(number, sumOfDigits);
        int[,] digitFrequency = FindDigitFrequency(digits);

        // Display results
        Console.WriteLine($"Digit count: {digitCount}");
        Console.WriteLine($"Sum of digits: {sumOfDigits}");
        Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");
        Console.WriteLine($"Is Harshad Number: {isHarshad}");
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < digitFrequency.GetLength(0); i++)
        {
            Console.WriteLine($"Digit {digitFrequency[i, 0]}: {digitFrequency[i, 1]} times");
        }
    }

    private int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    private int[] StoreDigits(int number, int digitCount)
    {
        int[] digits = new int[digitCount];
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    private int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    private int SumOfSquares(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    private bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }

    private int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
}