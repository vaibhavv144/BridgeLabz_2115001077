// using System;
// using System.IO;
// using Newtonsoft.Json.Linq;

// class Test8{
//     public static void Print()
//     {
//         string filePath = "data.json"; // JSON file to read

//         if (File.Exists(filePath))
//         {
//             string jsonContent = File.ReadAllText(filePath);
//             JObject jsonObject = JObject.Parse(jsonContent);

//             Console.WriteLine("JSON Keys and Values:");
//             foreach (var item in jsonObject)
//             {
//                 Console.WriteLine($"{item.Key}: {item.Value}");
//             }
//         }
//         else
//         {
//             Console.WriteLine("JSON file not found.");
//         }
//     }
// }
