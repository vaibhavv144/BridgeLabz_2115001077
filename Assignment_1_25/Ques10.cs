public class Ques10
{
    public static void Digit_Freq()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Temporary variable to process the number and count its digits
        int temp = number;
        int count = 0;

        // Count the number of digits in the input number
        while (temp > 0)
        {
            temp /= 10; // Remove the last digit
            count++;    // Increment the digit count
        }

        // Array to store the individual digits of the number
        int[] digits = new int[count];
        temp = number; // Reset temp to the original number

        // Extract each digit and store it in the array
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = temp % 10; // Get the last digit
            temp /= 10;           // Remove the last digit
        }

        // Array to store the frequency of each digit (0-9)
        int[] frequency = new int[10];

        // Calculate the frequency of each digit
        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++; // Increment the frequency for the current digit
        }

        // Display the digit frequency
        Console.WriteLine($"Digit Frequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] != 0) // Only display digits with non-zero frequency
            {
                Console.WriteLine($"{i}\t {frequency[i]}");
            }
        }
    }
}
