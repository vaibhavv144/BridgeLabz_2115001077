using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "DEFAULT_KEY";

    public static void DisplayKey()
    {
        Console.WriteLine($"API_KEY: {API_KEY}");
    }
}

class Test7{
    public static void Print(){
        Type type = typeof(Configuration);

        Configuration.DisplayKey();
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (field != null)
        {
            Console.Write("Enter new API_KEY: ");
            string newKey = Console.ReadLine();

            field.SetValue(null, newKey);

            Configuration.DisplayKey();
        }
        else
        {
            Console.WriteLine("Field not found.");
        }
    }
}

