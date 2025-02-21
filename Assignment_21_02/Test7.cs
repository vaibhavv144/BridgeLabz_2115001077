using System;

class Test7
{
    public static void Print()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = PerformDivision(numerator, denominator);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed.");
        }
    }

    public static int PerformDivision(int numerator, int denominator)
    {
        return numerator / denominator;
    }
}
