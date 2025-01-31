class Ques9{
    public static void BasicCalculator()
    {
        Console.WriteLine("Basic Calculator");
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        
        Console.Write("Choose operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result;
        switch (operation)
        {
            case '+':
                result = Add(num1, num2);
                break;
            case '-':
                result = Subtract(num1, num2);
                break;
            case '*':
                result = Multiply(num1, num2);
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
}