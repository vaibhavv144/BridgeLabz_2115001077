class Ques3{
    public static void PrimeNumberChecker()
    {
        Console.Write("Enter a number to check if it's prime: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = IsPrime(num);
        Console.WriteLine(num + (isPrime ? " is a prime number." : " is not a prime number."));
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        if (num == 2) return true;
        if (num % 2 == 0) return false;
        
        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}