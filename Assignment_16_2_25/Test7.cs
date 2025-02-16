using System;
using System.IO;

class Test7{
    public static void Print(){
        string filePath = "userinput.txt";

        try{
            Console.WriteLine("Please enter some text ");
            string userInput = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filePath)){
                writer.WriteLine(userInput);
            }
            Console.WriteLine("The input has been written to the file.");
        }catch (Exception ex){
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
