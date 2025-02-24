using System;
using System.Collections.Generic;
using System.Reflection;

class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        T obj = (T)Activator.CreateInstance(clazz);
        foreach (var prop in properties)
        {
            FieldInfo field = clazz.GetField(prop.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo property = clazz.GetProperty(prop.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(obj, Convert.ChangeType(prop.Value, field.FieldType));
            }
            else if (property != null && property.CanWrite)
            {
                property.SetValue(obj, Convert.ChangeType(prop.Value, property.PropertyType));
            }
        }
        return obj;
    }
}

public class Person1
{
    private string name;
    public int Age { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {name},\nAge: {Age}");
    }
}

class Test8
{
    public static void Print()
    {
        Dictionary<string, object> properties = new Dictionary<string, object>
        {
            { "name", "Vaibhav Singh" },
            { "Age", 22 }
        };

        Person1 person = ObjectMapper.ToObject<Person1>(typeof(Person1), properties);
        person.Display();
    }
}
