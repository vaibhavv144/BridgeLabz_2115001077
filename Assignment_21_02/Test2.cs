using System;
class Test2 {
    public static void Print() {
        HandleDivision();
    }

    private static void HandleDivision() {
        try {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (num2 == 0) {
                throw new DivideByZeroException();
            }
            
            double result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        } catch (DivideByZeroException) {
            Console.WriteLine("Error: Division by zero is not allowed.");
        } catch (FormatException) {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        } catch (Exception ex) {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
