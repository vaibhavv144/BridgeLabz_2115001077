using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Test5
{
    public static void Print()
    {
        // Define JSON schema
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'Name': { 'type': 'string' },
                'Email': { 'type': 'string', 'format': 'email' },
                'Age': { 'type': 'integer' }
            },
            'required': ['Name', 'Email', 'Age']
        }";

        JSchema schema = JSchema.Parse(schemaJson);

        // JSON object to validate
        string jsonString = @"{
            'Name': 'Vaibhav Singh',
            'Email': 'vaibhav@gmail.com',
            'Age': 25
        }";

        JObject jsonObject = JObject.Parse(jsonString);

        // Validate JSON
        bool isValid = jsonObject.IsValid(schema, out IList<string> errors);

        if (isValid)
        {
            Console.WriteLine("JSON is valid!");
        }
        else
        {
            Console.WriteLine("JSON is invalid:");
            foreach (string error in errors)
            {
                Console.WriteLine("- " + error);
            }
        }
    }
}
