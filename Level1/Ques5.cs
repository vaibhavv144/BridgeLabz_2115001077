class Ques5{
	public static int CheckNumberType(int number)
{
    // Check if the number is positive, negative, or zero
    if (number > 0)
    {
        return 1; // Positive number
    }
    else if (number < 0)
    {
        return -1; // Negative number
    }
    else
    {
        return 0; // Zero
    }
}
}