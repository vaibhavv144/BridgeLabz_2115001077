class Ques2{
   public static void ReverseString()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int length = arr.Length;

        // Reversing the string manually
        for (int i = 0; i < length / 2; i++)
        {
            char temp = arr[i];
            arr[i] = arr[length - 1 - i];
            arr[length - 1 - i] = temp;
        }

        // Display the reversed string
        Console.Write("Reversed String: ");
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}