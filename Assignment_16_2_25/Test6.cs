using System;
using System.IO;
class Test6{
    public static void Print(){
        string filePath = "binaryfile.bin";

        try{
           
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs)){
                string content = reader.ReadToEnd();
                Console.WriteLine("The content of the file as characters: ");
                Console.WriteLine(content);
            }
        }catch (Exception ex){
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
