using System;
using System.IO;

class Test5{
    public static void Print(){
        string Path = "textfile.txt";
        string searchWord = "data";
        int count = 0;

        try{
            string text = File.ReadAllText(Path);
            string[] words = text.Split(' ');
           
            foreach (string word in words){
                if (word.Equals(searchWord)){
                    count++;
                }
            }
            Console.WriteLine("The word '" + searchWord + "' appears " + count + " times in the file.");
        }catch (Exception ex){
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
