using System;
using System.Reflection;

class Student
{
    public string Name { get; set; }

    public Student()
    {
        Name = "Vaibhav Singh";
    }

    public void Display()
    {
        Console.WriteLine($"Student Name: {Name}");
    }
}

class Test4
{
    public static void Print()
    {
        Type type = typeof(Student);

        object obj = Activator.CreateInstance(type);

        MethodInfo method = type.GetMethod("Display");

        if (method != null)
        {
            method.Invoke(obj, null);
        }
        else
        {
            Console.WriteLine("Method not found.");
        }
    }
}
