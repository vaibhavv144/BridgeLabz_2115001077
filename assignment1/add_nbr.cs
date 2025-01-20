using System;

class add_nbr
{
    static void Main(string []args)
    {
        Console.WriteLine("Enter the first number:");
        int n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int n2 = int.Parse(Console.ReadLine());

        int sum = n1 + n2;
        Console.WriteLine("The sum is: " + sum);
    }
}
