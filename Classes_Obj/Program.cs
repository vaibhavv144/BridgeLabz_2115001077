class Program{
    public static void Main(string[] args){

        //Ques 1
    //     Ques1 employee = new Ques1();
        
    //     // Getting employee details from user input
    //     Console.Write("Enter Employee Name: ");
    //     employee.Name = Console.ReadLine();

    //     Console.Write("Enter Employee ID: ");
    //     employee.Id = int.Parse(Console.ReadLine());

    //     Console.Write("Enter Employee Salary: ");
    //     employee.Salary = double.Parse(Console.ReadLine());

    //     // Displaying the employee details
    //     Ques1.DisplayEmployeeDetails(employee);
    // }

    //Ques2 
        // Ques2 circle = new Ques2();
        
        // // Getting the radius from user input
        // Console.Write("Enter the radius of the circle: ");
        // circle.Radius = double.Parse(Console.ReadLine());

        // // Displaying the area and circumference of the circle
        // Ques2.DisplayCircleDetails(circle);

    //Ques 3
     // Creating an instance of Book
        Ques3 book = new Ques3();
        
        // Getting book details from user input
        Console.Write("Enter Book Title: ");
        book.Title = Console.ReadLine();

        Console.Write("Enter Book Author: ");
        book.Author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        book.Price = double.Parse(Console.ReadLine());

        // Displaying the book details
        book.DisplayBookDetails(book);
    }
}



