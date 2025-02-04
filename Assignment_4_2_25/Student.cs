using System;



class Test5{

    public static void Print(){

        while (true){

            Console.WriteLine("\n1. Add Student");

            Console.WriteLine("2. Total Students");

            Console.WriteLine("3. Exit");

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a){

                case 1:

                    Console.WriteLine("Enter the Student Name");

                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the Roll Number");

                    int rollNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Grade");

                    string grade = Console.ReadLine();

                    Student student1 = new Student(name, rollNumber, grade);

                    if (student1 is Student){

                        student1.DisplayDetails();

                    }

                    break;

                case 2:

                    Student.GetTotalStudents();  

                    break;

                case 3:

                    return; 

                default:

                    Console.WriteLine("INVALID ");

                    break;

            }

        }

    }

}



class Student{

    static string UniversityName = "GLA University"; 

    public string Name; 

    readonly int RollNumber; 

    public string Grade;

    public static int TotalStudents;  

    public Student(string Name, int RollNumber, string Grade){

        this.Name = Name;

        this.RollNumber = RollNumber;

        this.Grade = Grade;

        TotalStudents++;  

    }

    public static void GetTotalStudents(){

        Console.WriteLine("Total Students in " + UniversityName + " : " + TotalStudents);

    }

    public void DisplayDetails(){

        Console.WriteLine("\nUniversity Name : " + UniversityName);

        Console.WriteLine("Student Name : " + Name);

        Console.WriteLine("Roll Number : " + RollNumber);

        Console.WriteLine("Grade : " + Grade);

    }

}