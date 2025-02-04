using System;
class Employee{
    static string CompanyName = "Capgemini Consulting Private Limited"; 
    static int TotalEmployees = 0;  
    public string Name;
    public string Designation;
    readonly int Id;  
    public Employee(string name, int id, string designation){
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        TotalEmployees++; 
    }
    public static void DisplayTotalEmployees(){
        Console.WriteLine("\nTotal Employees in " + CompanyName + ": " + TotalEmployees);
    }
    public void DisplayDetails(){
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("==================");

        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Designation: " + Designation);
    }
}
class Test3{
    public static void Print(){
        while (true){
            Console.WriteLine("\n1. Add Employee & Display Details");
            Console.WriteLine("2. Display Total Employees");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Enter Employee Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Employee ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Employee Designation: ");
                    string designation = Console.ReadLine();
                    Employee newEmployee = new Employee(name, id, designation);
                      if (newEmployee is Employee){
                        newEmployee.DisplayDetails();
                    }else{
                        Console.WriteLine("Invalid Object");
                    }
                    break;

                case 2:
                    Employee.DisplayTotalEmployees();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}