class Ques12{
   public static void ReplaceWordInSentence()
    {
        // Taking input from user
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter the word to replace: ");
        string wordToReplace = Console.ReadLine();

        Console.Write("Enter the word to replace with: ");
        string replacementWord = Console.ReadLine();

        char[] arr = sentence.ToCharArray();
        int sentenceLength = arr.Length;
        int wordToReplaceLength = wordToReplace.Length;

        string result = "";
        string currentWord = "";

        // Traverse each character in the sentence
        for (int i = 0; i < sentenceLength; i++)
        {
            if (arr[i] != ' ' && i < sentenceLength) // Build the current word
            {
                currentWord += arr[i];
            }
            else
            {
                // If we find a word match, replace it
                if (currentWord == wordToReplace)
                {
                    result += replacementWord;
                }
                else
                {
                    result += currentWord;
                }

                // Add the space back and reset current word
                result += ' ';
                currentWord = "";
            }
        }

        // Checking for last word in case the sentence doesn't end with a space
        if (currentWord == wordToReplace)
        {
            result += replacementWord;
        }
        else
        {
            result += currentWord;
        }

        // Display the modified sentence
        Console.WriteLine("Modified Sentence: " + result);
    }
}