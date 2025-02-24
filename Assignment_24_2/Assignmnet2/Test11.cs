using System;  
using System.Collections.Generic;  
using System.Reflection;  
using System.Text.Json;  

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]  
public class JsonFieldAttribute : Attribute  
{  
    public string Name { get; }  

    public JsonFieldAttribute(string Name)  
    {  
        this.Name = Name;  
    }  
}  

public class Users  
{  
    [JsonField("user_name")]  
    public string Username { get; set; }  

    [JsonField("user_email")]  
    public string Email { get; set; }  

    public int Age { get; set; } // Not marked, should use default property name  

    public Users(string username, string email, int age)  
    {  
        Username = username;  
        Email = email;  
        Age = age;  
    }  
}  

public static class JsonSerializerCustom  
{  
    public static string Serialize(object obj)  
    {  
        Type type = obj.GetType();  
        Dictionary<string, object> jsonDict = new Dictionary<string, object>();  
        foreach (PropertyInfo prop in type.GetProperties())  
        {  
            object value = prop.GetValue(obj);  
            JsonFieldAttribute jsonFieldAttr = prop.GetCustomAttribute<JsonFieldAttribute>();  
            string key = jsonFieldAttr?.Name ?? prop.Name; // Use custom key if available, else default  
            jsonDict[key] = value;  
        }  
        return JsonSerializer.Serialize(jsonDict, new JsonSerializerOptions { WriteIndented = true });  
    }  
}  

public class Test11
{  
    public static void Print()  
    {  
        Users user = new Users("Vaibhav Singh", "vaibhav.singh@gmail.com", 22);  
        string jsonString = JsonSerializerCustom.Serialize(user);  
        Console.WriteLine("Serialized JSON:");  
        Console.WriteLine(jsonString);  
    }  
}
