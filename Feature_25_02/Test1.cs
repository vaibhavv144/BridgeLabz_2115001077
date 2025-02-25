using System;
using System.Reflection;

class Test1
{
    public static void Print(){
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine($"\nMethods in {className}:");
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine($"\nFields in {className}:");
        FieldInfo[] fields = type.GetFields();
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine($"\nConstructors in {className}:");
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor);
        }
    }
}
