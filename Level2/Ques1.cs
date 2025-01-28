// Question1.cs
using System;


class Ques1
{
    public void FindFactors()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find factors and store in an array
        int[] factors = GetFactors(number);

        // Calculate sum, sum of squares, and product of factors
        int sum = CalculateSum(factors);
        int sumOfSquares = CalculateSumOfSquares(factors);
        int product = CalculateProduct(factors);

        // Display results
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine($"Sum of factors: {sum}");
        Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");
        Console.WriteLine($"Product of factors: {product}");
    }

    private int[] GetFactors(int number)
    {
        List<int> factorList = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factorList.Add(i);
            }
        }
        return factorList.ToArray();
    }

    private int CalculateSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    private int CalculateSumOfSquares(int[] factors)
    {
        int sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += (int)Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    private int CalculateProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
}