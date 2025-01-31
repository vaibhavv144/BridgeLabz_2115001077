public class Ques1
{
      // Attributes of the Employee class
    public string Name;
    public int Id;
    public double Salary;

    // Method to display the employee details
    public static void DisplayEmployeeDetails(Ques1 emp)
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + emp.Name);
        Console.WriteLine("ID: " + emp.Id);
        Console.WriteLine("Salary: " + emp.Salary);
    }

}