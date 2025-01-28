class Ques10{

	public static int[] FindRemainderAndQuotient(int number, int divisor)
{
    // Calculate the quotient and remainder
    int quotient = number / divisor;
    int remainder = number % divisor;

    // Return the quotient and remainder as an array
    return new int[] { quotient, remainder };
}








}