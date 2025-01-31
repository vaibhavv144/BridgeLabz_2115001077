class Ques7{
    public static void CalculateGCDAndLCM()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2, gcd);

        Console.WriteLine("GCD of " + num1 + " and " + num2 + " is: " + gcd);
        Console.WriteLine("LCM of " + num1 + " and " + num2 + " is: " + lcm);
    }

    static int GCD(int a, int b)
    {
        return (b == 0) ? a : GCD(b, a % b);
    }

    static int LCM(int a, int b, int gcd)
    {
        return (a / gcd) * b;
    }
}