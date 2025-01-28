// Question5.cs
using System;

class Question5
{
    public void NumberCheckerTasks4()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        bool isPrime = IsPrimeNumber(number);
        bool isNeon = IsNeonNumber(number);
        bool isSpy = IsSpyNumber(number);
        bool isAutomorphic = IsAutomorphicNumber(number);
        bool isBuzz = IsBuzzNumber(number);

        // Display results
        Console.WriteLine($"Is Prime Number: {isPrime}");
        Console.WriteLine($"Is Neon Number: {isNeon}");
        Console.WriteLine($"Is Spy Number: {isSpy}");
        Console.WriteLine($"Is Automorphic Number: {isAutomorphic}");
        Console.WriteLine($"Is Buzz Number: {isBuzz}");
    }

    private bool IsPrimeNumber(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    private bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square != 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    private bool IsSpyNumber(int number)
    {
        int sum = 0, product = 1;
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    private bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square % (int)Math.Pow(10, number.ToString().Length) == number;
    }

    private bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
}