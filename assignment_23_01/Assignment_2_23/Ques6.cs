class Ques6{

    public static void FizzBuzz2(){
        // Prompt the user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if the entered number is a positive integer
        if (num <= 0){
            Console.WriteLine("Please enter a positive integer.");
            return; // Exit the method if the input is invalid
        }

        // Initialize a counter for the while loop
        int i = 1;

        // Loop through numbers from 1 to the entered number using a while loop
        while (i <= num){
            // Check if the number is divisible by both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            // Check if the number is divisible by 3
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            // Check if the number is divisible by 5
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            // Print the number if none of the above conditions are met
            else
                Console.WriteLine(i);

            // Increment the counter
            i++;
        }
    }
}
