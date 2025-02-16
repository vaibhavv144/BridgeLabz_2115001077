using System;
using System.IO;

class Test4{
   public static void Print(){
        string filePath = "textfile.txt";
        try{
            using (StreamReader reader = new StreamReader(filePath)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    Console.WriteLine(line+"\n");
                    Console.ReadKey();
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
