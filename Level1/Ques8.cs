class Ques8{
    public static void CompareStrings()
    {
        // Taking input from user
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        int len1 = arr1.Length;
        int len2 = arr2.Length;
        int minLength = (len1 < len2) ? len1 : len2;
        bool areEqual = true;

        // Lexicographical comparison
        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] != arr2[i])
            {
                areEqual = false;
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\" in lexicographical order.");
                }
                else
                {
                    Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + "\" in lexicographical order.");
                }
                return;
            }
        }

        // If the first part is equal, the shorter string comes first
        if (areEqual)
        {
            if (len1 == len2)
            {
                Console.WriteLine("Both strings are equal.");
            }
            else if (len1 < len2)
            {
                Console.WriteLine("\"" + str1 + "\" comes before \"" + str2 + "\" in lexicographical order.");
            }
            else
            {
                Console.WriteLine("\"" + str2 + "\" comes before \"" + str1 + "\" in lexicographical order.");
            }
        }
    }

}