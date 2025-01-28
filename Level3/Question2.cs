// Question2.cs
using System;

class Question2
{
    public void NumberCheckerTasks()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);
        bool isDuck = IsDuckNumber(digits);
        bool isArmstrong = IsArmstrongNumber(digits, digitCount);
        (int largest, int secondLargest) = FindLargestAndSecondLargest(digits);
        (int smallest, int secondSmallest) = FindSmallestAndSecondSmallest(digits);

        // Display results
        Console.WriteLine($"Digit count: {digitCount}");
        Console.WriteLine($"Is Duck Number: {isDuck}");
        Console.WriteLine($"Is Armstrong Number: {isArmstrong}");
        Console.WriteLine($"Largest digit: {largest}, Second largest digit: {secondLargest}");
        Console.WriteLine($"Smallest digit: {smallest}, Second smallest digit: {secondSmallest}");
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

    private bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit == 0)
                return true;
        }
        return false;
    }

    private bool IsArmstrongNumber(int[] digits, int digitCount)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, digitCount);
        }
        return sum == digits[0] * (int)Math.Pow(10, digitCount - 1) + digits[1] * (int)Math.Pow(10, digitCount - 2) + digits[2];
    }

    private (int, int) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue, secondLargest = Int32.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest)
            {
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }

    private (int, int) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue, secondSmallest = Int32.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest)
            {
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
}   