class Ques5{
   public static void FindLongestWord()
    {
        // Taking input from user
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;

        int maxLen = 0, currentLen = 0, start = 0, maxStart = 0;

        for (int i = 0; i <= length; i++)
        {
            if (i < length && (arr[i] >= 'A' && arr[i] <= 'Z' || arr[i] >= 'a' && arr[i] <= 'z'))
            {
                // Counting word length
                if (currentLen == 0)
                    start = i;
                currentLen++;
            }
            else
            {
                // Checking if it's the longest word
                if (currentLen > maxLen)
                {
                    maxLen = currentLen;
                    maxStart = start;
                }
                currentLen = 0;
            }
        }

        // Display the longest word
        Console.Write("Longest Word: ");
        for (int i = maxStart; i < maxStart + maxLen; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}