class Ques4{
    public static void RemoveDuplicates()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;
        char[] result = new char[length];
        int index = 0;

        // Checking and storing unique characters
        for (int i = 0; i < length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < index; j++)
            {
                if (arr[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                result[index] = arr[i];
                index++;
            }
        }

        // Display the modified string
        Console.Write("Modified String: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}