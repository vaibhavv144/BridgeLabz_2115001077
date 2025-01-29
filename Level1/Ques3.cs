class Ques3{
    public static void CheckPalindrome()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;
        bool isPalindrome = true;

        // Checking palindrome condition
        for (int i = 0; i < length / 2; i++)
        {
            if (arr[i] != arr[length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        // Display result
        if (isPalindrome)
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }

    
}