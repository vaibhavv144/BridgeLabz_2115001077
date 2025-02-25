using System;
using System.Reflection;

class Person
{
    private int age = 25;

    public void DisplayAge()
    {
        Console.WriteLine($"Age: {age}");
    }
}

class Test2
{
    public static void Print()
    {
        Person person = new Person();
        Type type = typeof(Person);
        Console.Write("Enter new age: ");
        person.DisplayAge();
        if (int.TryParse(Console.ReadLine(), out int newAge))
        {
            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(person, newAge);
                int modifiedAge = (int)field.GetValue(person);
                Console.WriteLine($"Modified Age: {modifiedAge}");
                person.DisplayAge();
            }
            else
            {
                Console.WriteLine("Field not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
