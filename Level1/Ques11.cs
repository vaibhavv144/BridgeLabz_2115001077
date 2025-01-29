class Ques11{
   public static void CheckAnagram()
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

        // If lengths are different, they cannot be anagrams
        if (len1 != len2)
        {
            Console.WriteLine("The strings are not anagrams.");
            return;
        }

        // Sorting both arrays manually
        for (int i = 0; i < len1 - 1; i++)
        {
            for (int j = i + 1; j < len1; j++)
            {
                if (arr1[i] > arr1[j])
                {
                    char temp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }

                if (arr2[i] > arr2[j])
                {
                    char temp = arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp;
                }
            }
        }

        // Checking if both sorted arrays are equal
        bool isAnagram = true;
        for (int i = 0; i < len1; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isAnagram = false;
                break;
            }
        }

        // Display result
        if (isAnagram)
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }

}