using System;

public class Ques7
{
    public static void SeparateOddEvenNumbers()
    {
        // Prompt the user to enter a natural number
        Console.WriteLine("Enter a natural number:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Validate that the input is a natural number
        if (number <= 0)
        {
            Console.Error.WriteLine("Error: Please enter a natural number greater than 0.");
            return;
        }

        // Initialize arrays to store odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0;
        int evenIndex = 0;

        // Populate odd and even number arrays
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i; // Add to even numbers
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i; // Add to odd numbers
                oddIndex++;
            }
        }

        // Display odd numbers
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Display even numbers
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++);
  
    }
}
