using System;

class Test8
{
    public static void Print()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }

    public static void Method1()
    {
   
        throw new ArithmeticException("Attempted to divide by zero");
    }

    public static void Method2()
    {
        Method1();
    }
}
