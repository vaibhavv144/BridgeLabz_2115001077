using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
   
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("John Doe")]
class SampleClass
{
    public void Display()
    {
        Console.WriteLine("This is a sample class.");
    }
}

class Test6
{
    public static void Print(){
        Type type = typeof(SampleClass);
        AuthorAttribute? authorAttribute = (AuthorAttribute?)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (authorAttribute != null)
        {
            Console.WriteLine($"Author: {authorAttribute.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
