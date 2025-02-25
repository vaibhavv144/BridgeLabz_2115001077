
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
 
class JsonConverter
{
	public static string ToJson(object obj)
	{
    	if (obj == null) return "{}";
 
    	Type type = obj.GetType();
    	StringBuilder jsonBuilder = new StringBuilder();
    	jsonBuilder.Append("{");
 
    	FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
    	PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
 
    	List<string> keyValuePairs = new List<string>();
 
    	foreach (var field in fields)
    	{
        	object value = field.GetValue(obj) ?? "null";
        	keyValuePairs.Add($"\"{field.Name}\": \"{value}\"");
    	}
 
    	foreach (var property in properties)
    	{
        	if (property.CanRead)
            {
                object value = property.GetValue(obj) ?? "null";
                keyValuePairs.Add($"\"{property.Name}\": \"{value}\"");
            }
    	}
 
    	jsonBuilder.Append(string.Join(", ", keyValuePairs));
    	jsonBuilder.Append("}");
 
    	return jsonBuilder.ToString();
	}
}
 
class Person2
{
	private string name = "Vaibhav Singh";
	public int Age { get; set; } = 22;
}
 
class Test9
{
	public static void Print()
	{
    	Person2 person = new Person2();
    	string json = JsonConverter.ToJson(person);
    	Console.WriteLine(json);
	}
}

