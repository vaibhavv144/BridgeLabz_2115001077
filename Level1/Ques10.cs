class Ques10{
      public static void RemoveCharacter()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char removeChar = Console.ReadLine()[0];

        char[] arr = input.ToCharArray();
        int length = arr.Length;
        char[] result = new char[length];
        int index = 0;

        // Removing occurrences of the specified character
        for (int i = 0; i < length; i++)
        {
            if (arr[i] != removeChar)
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