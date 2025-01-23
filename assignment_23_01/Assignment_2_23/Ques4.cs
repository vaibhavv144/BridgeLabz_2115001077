class Ques4{
    public static void IsPrime(){
        // Prompt the user to enter a number greater than 1
        Console.Write("Enter a number greater than 1: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if the number is less than or equal to 1
        if (num <= 1){
            Console.WriteLine("Prime numbers are greater than 1.");
            return; // Exit the method if the number is not valid
        }

        // Initialize a flag to determine if the number is prime
        bool isPrime = true;

        // Loop through numbers from 2 to one less than the entered number
        for (int i = 2; i < num; i++){
            // Check if the number is divisible by any number in the range
            if (num % i == 0){
                isPrime = false; // Set flag to false if divisible
                break; // Exit the loop as the number is not prime
            }
        }

        // Output whether the number is prime or not
        if (isPrime){
            Console.WriteLine($"{num} is a Prime Number.");
        }else{
            Console.WriteLine($"{num} is NOT a Prime Number.");
        }
    }
}
