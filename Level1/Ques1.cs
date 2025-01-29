class Ques1{
    public static void CountVowelsAndConsonants()
    {
        // Taking input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowels = 0, consonants = 0;
        char[] arr = input.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            char ch = arr[i];

            // Convert to lowercase for uniformity
            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }

            // Check for vowels and consonants
            if ((ch >= 'a' && ch <= 'z'))
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }

        // Display the counts
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}