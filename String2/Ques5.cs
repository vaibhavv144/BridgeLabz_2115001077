class Ques5{
    public static void CheckPalindrome()
    {
        Console.Write("Enter a string to check if it's a palindrome: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine(isPalindrome ? "The string is a palindrome." : "The string is not a palindrome.");
    }

    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (char.ToLower(str[left]) != char.ToLower(str[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}