using System;
class Test9 {
    public static void Print() {
      
        Teacher teacher = new Teacher("Mr. Vinay Sinha", 40, "Mathematics");
        Student student = new Student("Aditya ", 16, "10th Grade");
        Staff staff = new Staff("Mrs. Renuka", 35, "Administration");
        Console.WriteLine("=== Teacher Details ===");
        teacher.DisplayRole();
        teacher.DisplayDetails();
        Console.WriteLine();
        Console.WriteLine("=== Student Details ===");
        student.DisplayRole();
        student.DisplayDetails();
        Console.WriteLine();
        Console.WriteLine("=== Staff Details ===");
        staff.DisplayRole();
        staff.DisplayDetails();
    }
}

class Person {
    public string Name ;
    public int Age ;

    // Constructor
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }

    // Virtual method 
    public virtual void DisplayDetails() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }

    // Virtual method 
        public virtual void DisplayRole() {
        Console.WriteLine("Role: General Person");
    }
}

// Subclass Teacher
class Teacher : Person {
    public string Subject ;
    // Constructor
    public Teacher(string name, int age, string subject)
        : base(name, age) {
        Subject = subject;
    }

    // Overriding 
    public override void DisplayRole() {
        Console.WriteLine("Role: Teacher");
    }

    // Overriding 
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Subject: {Subject}");
    }
}

// Subclass Student
class Student : Person {
    public string Grade ;

    // Constructor
    public Student(string name, int age, string grade)
        : base(name, age) {
        Grade = grade;
    }

    // Overriding 
    public override void DisplayRole() {
        Console.WriteLine("Role: Student");
    }

    // Overriding 
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Grade: {Grade}");
    }
}

// Subclass Staff
class Staff : Person {
    public string Department;

    // Constructor
    public Staff(string name, int age, string department)
        : base(name, age) {
        Department = department;
    }

    // Overriding 
    public override void DisplayRole() {
        Console.WriteLine("Role: Staff Member");
    }

    // Overriding 
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Department: {Department}");
    }
}
