class Ques6{
    public static void CountSubstringOccurrences()
    {
        // Taking input from user
        Console.Write("Enter the main string: ");
        string mainStr = Console.ReadLine();

        Console.Write("Enter the substring to count: ");
        string subStr = Console.ReadLine();

        char[] mainArr = mainStr.ToCharArray();
        char[] subArr = subStr.ToCharArray();

        int mainLength = mainArr.Length;
        int subLength = subArr.Length;
        int count = 0;

        // Checking occurrences of substring manually
        for (int i = 0; i <= mainLength - subLength; i++)
        {
            bool match = true;
            for (int j = 0; j < subLength; j++)
            {
                if (mainArr[i + j] != subArr[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }

        // Display the count
        Console.WriteLine("Occurrences of substring: " + count);
    }

}