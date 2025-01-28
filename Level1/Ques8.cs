class Ques8{

public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
{
    // Find the smallest and largest number
    int smallest = Math.Min(number1, Math.Min(number2, number3));
    int largest = Math.Max(number1, Math.Max(number2, number3));

    // Return the smallest and largest numbers as an array
    return new int[] { smallest, largest };
}
}