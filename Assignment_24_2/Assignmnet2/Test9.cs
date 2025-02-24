    using System;  
using System.Reflection;  

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]  
public class MaxLengthAttribute : Attribute  
{  
    public int Length { get; }  

    public MaxLengthAttribute(int length)  
    {  
        Length = length;  
    }  
}  

public class User  
{  
    [MaxLength(10)] // Restrict Username length to 10 characters  
    public string Username { get; }  

    public User(string username)  
    {  
        ValidateMaxLength(username, nameof(Username));  
        Username = username;  
    }  

    private void ValidateMaxLength(string value, string propertyName)  
    {  
        PropertyInfo property = typeof(User).GetProperty(propertyName);  
        MaxLengthAttribute maxLengthAttr = property?.GetCustomAttribute<MaxLengthAttribute>();  
        if (maxLengthAttr != null && value.Length > maxLengthAttr.Length)  
        {  
            throw new ArgumentException($"{propertyName} cannot exceed {maxLengthAttr.Length} characters.");  
        }  
    }  
}  

public class Test9  
{  
    public static void Print()  
    {  
        try  
        {  
            User validUser  = new User("Vaibhav Singh");
            Console.WriteLine($"User  created: {validUser .Username}");  
            User invalidUser  = new User("VeryLongUsername");  
            Console.WriteLine($"User  created: {invalidUser .Username}");  
        }  
        catch (ArgumentException ex)  
        {  
            Console.WriteLine($"Error: {ex.Message}");  
        }  
    }  
}
