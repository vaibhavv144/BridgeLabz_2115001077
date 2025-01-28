class Ques7{
public static void FindSumOfNaturalNumbers()
{
    // Get input from the user
    Console.Write("Enter a number (n): ");
    int n = Convert.ToInt32(Console.ReadLine());

    // Initialize the sum variable
    int sum = 0;

    // Loop to calculate the sum of first 'n' natural numbers
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }

    // Print the result
    Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
}
}