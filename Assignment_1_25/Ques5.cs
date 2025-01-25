Ques5{
public static void ReverseNumber()
{
    // Input number from the user
    Console.Write("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    // Initial size of the array
    int maxDigit = 10;
    int[] digits = new int[maxDigit];
    int index = 0;

    // Extract digits from the number and store them in the array
    while (number != 0)
    {
        // If the array is full, increase its size
        if (index == maxDigit)
        {
            maxDigit += 10; // Increase maxDigit by 10
            int[] temp = new int[maxDigit]; // Create a new temp array
            for (int i = 0; i < digits.Length; i++)
            {
                temp[i] = digits[i]; // Copy existing digits to the temp array
            }
            digits = temp; // Assign temp array to digits
        }

        digits[index] = number % 10; // Get the last digit
        number /= 10; // Remove the last digit
        index++;
    }

    // Create a reversed array
    int[] reversedDigits = new int[index];
    for (int i = 0; i < index; i++)
    {
        reversedDigits[i] = digits[index - i - 1];
    }

    // Output the reversed number
    Console.WriteLine("\n--- Reversed Digits ---");
    Console.Write("Reversed number: ");
    foreach (int digit in reversedDigits)
    {
        Console.Write(digit);
    }
    Console.WriteLine();
}
}