class Ques4{
 
    public static void GenerateFibonacci()
    {
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int terms = int.Parse(Console.ReadLine());

        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int first = 0, second = 1, next;
        Console.Write("Fibonacci Sequence: " + first);

        if (terms > 1)
        {
            Console.Write(", " + second);
        }

        for (int i = 3; i <= terms; i++)
        {
            next = first + second;
            Console.Write(", " + next);
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
}