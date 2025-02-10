using System;
using System.Collections.Generic;
interface IDepartment{
    void AssignDepartment(string department);
    string GetDepartmentDetails();
}
abstract class Employee{
    private int employeeId;
    private string name;
    private double baseSalary;
    private string department;
    public int EmployeeId{
        get { return employeeId; }
        protected set { employeeId = value; }
    }
    public string Name{
        get { return name; }
        protected set { name = value; }
    }
    public double BaseSalary{
        get { return baseSalary; }
        protected set { baseSalary = value; }
    }
    public string Department{
        get { return department; }
        protected set { department = value; }
    }
    // Constructor
    public Employee(int id, string name, double salary){
        this.EmployeeId = id;
        this.Name = name;
        this.BaseSalary = salary;
    }
    // Abstract method 
    public abstract double CalculateSalary();
    // Concrete method 
    public void DisplayDetails(){
        Console.WriteLine($"ID: {EmployeeId}, \nName: {Name}, \nSalary: {CalculateSalary():C}, \nDepartment: {Department}\n\n");
    }
}

// Full-time employee class
class FullTimeEmployee : Employee, IDepartment{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary) { }

    // Implement salary 
    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    // Implement interface methods
    public void AssignDepartment(string department){
        Department = department;
    }

    public string GetDepartmentDetails(){
        return $"Full-time Employee {Name} is in {Department} department.";
    }
}

class PartTimeEmployee : Employee, IDepartment{
    private int workHours;
    private double hourlyRate;

    public PartTimeEmployee(int id, string name, double hourlyRate, int workHours)
        : base(id, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.workHours = workHours;
    }

    // Implement salary 
    public override double CalculateSalary(){
        return workHours * hourlyRate;
    }

    // Implement interface methods
    public void AssignDepartment(string department){
        Department = department;
    }

    public string GetDepartmentDetails(){
        return $"Part-time Employee {Name} is in {Department} department.";
    }
}


class Test1{
    public static void Print(){
        // List to store different types of employees (Polymorphism)
        List<Employee> employees = new List<Employee>();
        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Prabhat Kumar", 50000);
        emp1.AssignDepartment("IT");

        PartTimeEmployee emp2 = new PartTimeEmployee(102, "Vaibhav Singh", 200, 25);
        emp2.AssignDepartment("HR");

        employees.Add(emp1);
        employees.Add(emp2); 

        // Display details using base class reference (Polymorphism)
        foreach (var emp in employees){
            emp.DisplayDetails();
        }
    }
}