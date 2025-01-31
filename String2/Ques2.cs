using System;

class Ques2
{
    public static void MaxOfThreeNumbers()
    {
        // Prompt the user for input
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        // Call the method to calculate the maximum
        int max = CalculateMax(num1, num2, num3);
        Console.WriteLine("The maximum number is: " + max);
    }

    // Method to calculate the maximum of three numbers
    static int CalculateMax(int a, int b, int c)
    {
        return (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
    }
}
