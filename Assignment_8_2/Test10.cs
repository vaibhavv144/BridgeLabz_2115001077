using System;
class Test10 {
    public static void Print() {
       
        Chef chef = new Chef("Mr. Samrat", 101, "Butter Paneer");
        Waiter waiter = new Waiter("Jasawat", 102, 5);
        Console.WriteLine("=== Chef Details ===");
        chef.DisplayDetails();
        chef.PerformDuties();
        Console.WriteLine();
        Console.WriteLine("=== Waiter Details ===");
        waiter.DisplayDetails();
        waiter.PerformDuties();
    }
}

// Superclass
class Person1 {
    public string Name ;
    public int Id;
    // Constructor
    public Person1(string name, int id) {
        Name = name;
        Id = id;
    }
    // Virtual 
    public virtual void DisplayDetails() {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"ID: {Id}");
    }
}

// Interface Worker
interface IWorker {
    void PerformDuties(); 
}

// Subclass Chef 
class Chef : Person1, IWorker {
    public string Specialty ;

    // Constructor
    public Chef(string name, int id, string specialty)
        : base(name, id) {
        Specialty = specialty;
    }

    // Implementing method
    public void PerformDuties() {
        Console.WriteLine($"{Name} is preparing {Specialty} dishes.");
    }

    // Overriding 
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Specialty: {Specialty}");
    }
}

// Subclass Waiter
class Waiter : Person1, IWorker {
    public int TablesAssigned ;

    // Constructor
    public Waiter(string name, int id, int tablesAssigned)
        : base(name, id) {
        TablesAssigned = tablesAssigned;
    }

    // Implementing  method
    public void PerformDuties() {
        Console.WriteLine($"{Name} is serving customers at {TablesAssigned} tables.");
    }

    // Overriding 
    public override void DisplayDetails() {
        base.DisplayDetails();
        Console.WriteLine($"Tables Assigned: {TablesAssigned}");
    }
}

