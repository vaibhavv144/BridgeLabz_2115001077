class Ques6{
    static void CalculateFactorial()
    {
        Console.Write("Enter a number to calculate its factorial: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        long result = Factorial(num);
        Console.WriteLine("The factorial of " + num + " is: " + result);
    }

    static long Factorial(int n)
    {
        return (n == 0 || n == 1) ? 1 : n * Factorial(n - 1);
    }

}