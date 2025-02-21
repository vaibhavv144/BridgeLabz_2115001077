using System;
class Test1 {
    public static void Print() {
        string filePath = "data.txt";
        ReadFile(filePath);
    }

    private static void ReadFile(string filePath) {
        try {
            if (!File.Exists(filePath)) {
                throw new FileNotFoundException();
            }

            using (StreamReader reader = new StreamReader(filePath)) {
                string content = reader.ReadToEnd();
                Console.WriteLine("File Contents:\n" + content);
            }
        } catch (FileNotFoundException) {
            Console.WriteLine("File not found.");
        } catch (IOException ex) {
            Console.WriteLine("File read error: " + ex.Message);
        }
    }
}
