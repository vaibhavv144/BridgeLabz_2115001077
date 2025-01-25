class Ques4{


public static void Ques3_Different()
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

    // Variables to store the largest and second largest digits
    int largest = 0;
    int secondLargest = 0;

    // Loop through the array to find the largest and second largest digits
    for (int i = 0; i < index; i++)
    {
        if (digits[i] > largest)
        {
            secondLargest = largest; // Update second largest
            largest = digits[i]; // Update largest
        }
        else if (digits[i] > secondLargest && digits[i] != largest)
        {
            secondLargest = digits[i];
        }
    }

    Console.WriteLine($"Largest digit: {largest}");
    Console.WriteLine($"Second largest digit: {secondLargest}");
}

}