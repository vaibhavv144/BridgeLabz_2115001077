// Question4.cs
using System;

class Question4
{
    public void NumberCheckerTasks3()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);
        int[] reversedDigits = ReverseDigits(digits);
        bool areArraysEqual = CompareArrays(digits, reversedDigits);
        bool isPalindrome = IsPalindrome(digits, reversedDigits);
        bool isDuck = IsDuckNumber(digits);

        // Display results
        Console.WriteLine($"Digit count: {digitCount}");
        Console.WriteLine($"Are arrays equal: {areArraysEqual}");
        Console.WriteLine($"Is Palindrome: {isPalindrome}");
        Console.WriteLine($"Is Duck Number: {isDuck}");
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

    private int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    private bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
            return false;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
                return false;
        }
        return true;
    }

    private bool IsPalindrome(int[] digits, int[] reversedDigits)
    {
        return CompareArrays(digits, reversedDigits);
    }

    private bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit == 0)
                return true;
        }
        return false;
    }
}