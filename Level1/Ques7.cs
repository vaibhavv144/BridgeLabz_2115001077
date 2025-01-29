class Ques7{
   public static void static void ToggleCase()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;

        // Toggling case of each character
        for (int i = 0; i < length; i++)
        {
            if (arr[i] >= 'A' && arr[i] <= 'Z')
            {
                arr[i] = (char)(arr[i] + 32); // Convert uppercase to lowercase
            }
            else if (arr[i] >= 'a' && arr[i] <= 'z')
            {
                arr[i] = (char)(arr[i] - 32); // Convert lowercase to uppercase
            }
        }

        // Display the modified string
        Console.Write("Toggled String: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }

    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;

        // Toggling case of each character
        for (int i = 0; i < length; i++)
        {
            if (arr[i] >= 'A' && arr[i] <= 'Z')
            {
                arr[i] = (char)(arr[i] + 32); // Convert uppercase to lowercase
            }
            else if (arr[i] >= 'a' && arr[i] <= 'z')
            {
                arr[i] = (char)(arr[i] - 32); // Convert lowercase to uppercase
            }
        }

        // Display the modified string
        Console.Write("Toggled String: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }

}