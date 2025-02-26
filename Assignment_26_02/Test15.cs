// using System;
// using System.Collections.Generic;
// using System.Data.SQLite;
// using System.IO;
// using Newtonsoft.Json;

// class Test15
// {
//     public static void Print()
//     {
//         string dbPath = "database.db";  
//         string jsonFilePath = "report.json";

 
//         List<Dictionary<string, object>> records = FetchRecords(dbPath);

//         string jsonReport = JsonConvert.SerializeObject(records, Formatting.Indented);
//         File.WriteAllText(jsonFilePath, jsonReport);

//         Console.WriteLine($"JSON Report saved to: {jsonFilePath}");
//         Console.WriteLine("Generated JSON Report:\n" + jsonReport);
//     }


//     public static List<Dictionary<string, object>> FetchRecords(string dbPath)
//     {
//         List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();

//         using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
//         {
//             connection.Open();
//             string selectQuery = "SELECT * FROM Students";  
//             SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
//             using (SQLiteDataReader reader = command.ExecuteReader())
//             {
//                 while (reader.Read())
//                 {
//                     Dictionary<string, object> record = new Dictionary<string, object>();
//                     for (int i = 0; i < reader.FieldCount; i++)
//                     {
//                         record[reader.GetName(i)] = reader.GetValue(i);
//                     }
//                     records.Add(record);
//                 }
//             }
//         }
//         return records;
//     }
// }
