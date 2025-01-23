class Ques10{
    public static void PowerCalcu(){
        // Prompt user to enter a number
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Prompt user to enter the power
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        // Initialize result to 1 as the starting point for multiplication
        int result = 1;

        // Loop to multiply the number by itself 'power' times
        for (int i = 1; i <= power; i++){
            result *= number; // Multiply result by the number in each iteration
        }

        // Display the final result of the power calculation
        Console.WriteLine($"{number} raised to the power of {power} is: {result}");
    }
}
