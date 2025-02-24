using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Test3{
    public static void Print()
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

        if (method != null)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            object result = method.Invoke(calculator, new object[] { num1, num2 });

            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
