// Question6.cs
using System;

class Question6
{
    public void NumberCheckerTasks5()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        int[] factors = FindFactors(number);
        int greatestFactor = FindGreatestFactor(factors);
        int sumOfFactors = SumOfFactors(factors);
        int productOfFactors = ProductOfFactors(factors);
        double productOfCubes = ProductOfCubes(factors);
        bool isPerfect = IsPerfectNumber(number, sumOfFactors);
        bool isAbundant = IsAbundantNumber(number, sumOfFactors);
        bool isDeficient = IsDeficientNumber(number, sumOfFactors);
        bool isStrong = IsStrongNumber(number);

        // Display results
        Console.WriteLine($"Factors: {string.Join(", ", factors)}");
        Console.WriteLine($"Greatest Factor: {greatestFactor}");
        Console.WriteLine($"Sum of Factors: {sumOfFactors}");
        Console.WriteLine($"Product of Factors: {productOfFactors}");
        Console.WriteLine($"Product of Cubes of Factors: {productOfCubes}");
        Console.WriteLine($"Is Perfect Number: {isPerfect}");
        Console.WriteLine($"Is Abundant Number: {isAbundant}");
        Console.WriteLine($"Is Deficient Number: {isDeficient}");
        Console.WriteLine($"Is Strong Number: {isStrong}");
    }

    private int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }
        return factors;
    }

    private int FindGreatestFactor(int[] factors)
    {
        return factors[factors.Length - 2]; // Second last element is the greatest factor
    }

    private int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    private int ProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }

    private double ProductOfCubes(int[] factors)
    {
        double product = 1;
        foreach (int factor in factors)
        {
            product *= Math.Pow(factor, 3);
        }
        return product;
    }

    private bool IsPerfectNumber(int number, int sumOfFactors)
    {
        return sumOfFactors - number == number;
    }

    private bool IsAbundantNumber(int number, int sumOfFactors)
    {
        return sumOfFactors - number > number;
    }

    private bool IsDeficientNumber(int number, int sumOfFactors)
    {
        return sumOfFactors - number < number;
    }

    private bool IsStrongNumber(int number)
    {
        int sumOfFactorials = 0;
        int temp = number;
        while (temp != 0)
        {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }
        return sumOfFactorials == number;
    }

    private int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}