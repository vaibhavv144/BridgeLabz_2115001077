class Ques12{
    public static void Multiples(){
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Display the message indicating the start of multiples of the entered number
        Console.WriteLine($"Multiples of {number} below 100 are:");

        // Loop from 100 down to 1 to find multiples of the entered number
        for (int i = 100; i >= 1; i--){
            // Check if i is a multiple of the entered number
            if (i % number == 0){
                Console.WriteLine(i); // Print the multiple
            }
        }
    }
}
