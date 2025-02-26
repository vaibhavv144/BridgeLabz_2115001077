using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Test11{
    public static void Print()    {
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'Email': { 'type': 'string', 'format': 'email' }
            },
            'required': ['Email']
        }";

        JSchema schema = JSchema.Parse(schemaJson);

        List<string> jsonObjects = new List<string>
        {
            @"{ 'Email': 'vaibhav@gmail.com' }",  // Valid Email
            @"{ 'Email': 'invalid-email' }",       // Invalid Email
            @"{ 'Name': 'vaibhav' }"                // Missing Email Field
        };

        foreach (string jsonString in jsonObjects)
        {
            JObject jsonObject = JObject.Parse(jsonString);
            bool isValid = jsonObject.IsValid(schema, out IList<string> errors);

            Console.WriteLine($"JSON: {jsonString}");
            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
           
            if (!isValid)
            {
                foreach (string error in errors)
                {
                    Console.WriteLine($"{error}");
                }
            }
            Console.WriteLine();
        }
    }
}
