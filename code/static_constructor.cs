using System;

class Example
{
    static int staticValue;

    // Static constructor
    static Example()
    {
        staticValue = 42;
        Console.WriteLine("Static Constructor Invoked");
    }

    public static void DisplayValue()
    {
        Console.WriteLine(staticValue);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Usage
        Example.DisplayValue(); // Triggers the static constructor
    }
}
