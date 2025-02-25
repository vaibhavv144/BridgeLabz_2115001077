using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class Test5{
    public static void Print(){
        MathOperations mathOps = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        MethodInfo method = type.GetMethod(methodName);

        if (method != null)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            object result = method.Invoke(mathOps, new object[] { num1, num2 });

            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
