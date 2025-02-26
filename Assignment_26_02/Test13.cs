using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

class Test13
{
    public static void Print()
    {
        string json = @"{
            'Name': 'Vaibhav Singh',
            'Age': 25,
            'Email': 'vaibhav@gmail.com'
        }";

        // Convert JSON to XML
        JObject jsonObject = JObject.Parse(json);
        XDocument xmlDocument = JsonConvert.DeserializeXNode(jsonObject.ToString(), "Root");

        // Print XML format
        Console.WriteLine("Converted XML:\n" + xmlDocument);
    }
}
