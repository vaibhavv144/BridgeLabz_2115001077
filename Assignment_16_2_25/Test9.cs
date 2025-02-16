using System;

class Test9{
    public static void Print(){
        Console.Write("Enter the number of sentences: ");
        int n = int.Parse(Console.ReadLine());
        string[] sentences = new string[n];

        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++){
            sentences[i] = Console.ReadLine();
        }

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine();

        int Index = find(sentences, word);
        if (Index != -1){
            Console.WriteLine("The first sentence is: \n" + sentences[Index]);
        }else{
            Console.WriteLine("No sentence contains the word '" + word + "'.");
        }
    }

    public static int find(string[] sentences, string word){
        for (int i = 0; i < sentences.Length; i++){  
            if (sentences[i].Contains(word)){
                return i;
            }
        }
        return -1;
    }
}
