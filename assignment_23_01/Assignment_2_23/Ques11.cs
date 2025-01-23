class Ques11{
    public static void FactorFind(){
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Display the message indicating the start of factors
        Console.WriteLine($"Factors of {number} are:");

        // Loop through numbers from 1 to number-1 to find the factors
        for (int i = 1; i < number; i++){
            // Check if i is a factor of the entered number
            if (number % i == 0){
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}
