using System;
class Test2 {
    public static void Print() {
        
        Employee manager = new Manager("Vaibhav", 1, 75000, 5);
        Employee developer = new Developer("Ayush", 11, 60000, "C#");
        Employee intern = new Intern("Aditya", 111, 20000, "6 months");
        manager.DisplayDetails();
        Console.WriteLine(); 
        developer.DisplayDetails();
        Console.WriteLine();
        intern.DisplayDetails();
    }
}
class Employee {
    public string Name ;
    public int Id ;
    public double Salary;
    public Employee(string name, int id, double salary) {
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Virtual method 
    public virtual void DisplayDetails() {
        Console.WriteLine($"Employee ID: {Id}\nName: {Name},\nSalary: {Salary:C}");
    }
}

// Subclass
class Manager : Employee {
    public int TeamSize ;
    public Manager(string name, int id, double salary, int teamSize)
        : base(name, id, salary) {
        TeamSize = teamSize;
    }

    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Role: Manager,\nTeam Size: {TeamSize}");
    }
}

// Subclass
class Developer : Employee {
    public string ProgrammingLanguage ;

    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary) {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Role: Developer,\nProgramming Language: {ProgrammingLanguage}");
    }
}

// Subclass
class Intern : Employee {
    public string InternshipDuration ;

    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary) {
        InternshipDuration = internshipDuration;
    }

    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Role: Intern,\nInternship Duration: {InternshipDuration}");
    }
}
