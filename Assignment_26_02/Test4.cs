using System;
using Newtonsoft.Json.Linq;

class Test4{
    public static void Print(){
        // First JSON object
        JObject json1 = JObject.Parse(@"{
            'Name': 'Vaibhav Singh',
            'Email': 'vaibhavsingh144@gmail.com'
        }");

        // Second JSON object
        JObject json2 = JObject.Parse(@"{
            'Age': 25,
            'Address': 'India'
        }");

        // Merge json2 into json1
        json1.Merge(json2, new JsonMergeSettings
        {
            MergeArrayHandling = MergeArrayHandling.Union
        });

        Console.WriteLine("Merged JSON:\n" + json1.ToString());
    }
}
