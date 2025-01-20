using System;

class simple_int
{
    static void Main(string []args)
    {
        Console.WriteLine("Enter the Principal amount:");
        double principal = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Rate of interest:");
        double rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Time period (in years):");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time)/100 ;
        Console.WriteLine("Simple Interest: " + simpleInterest);
    }
}
