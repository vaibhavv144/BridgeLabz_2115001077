class Ques9{
    public static void FindMostFrequentCharacter()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;
        int maxCount = 0;
        char mostFrequentChar = '\0';

        // Counting frequency of each character
        for (int i = 0; i < length; i++)
        {
            int count = 0;
            for (int j = 0; j < length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            // Update most frequent character
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentChar = arr[i];
            }
        }

        // Display result
        Console.WriteLine("Most Frequent Character: '" + mostFrequentChar + "'");
    }
}