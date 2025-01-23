class Ques9{
    public static void GreatestFactor(){
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize greatestFactor to 1, as 1 is a factor of all numbers
        int greatestFactor = 1;

        // Loop through numbers from number-1 down to 1 to find the greatest factor
        for (int i = number - 1; i >= 1; i--){
            // Check if i is a factor of the number
            if (number % i == 0){
                greatestFactor = i; // Update greatestFactor if a factor is found
                break; // Exit the loop once the greatest factor is found
            }
        }

        // Display the greatest factor of the entered number
        Console.WriteLine($"The greatest factor of {number} : {greatestFactor}");
    }
}
