using System;

class Student{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public Student Next;

    public Student(int rollNumber, string name, int age, char grade){
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentList{
    private Student head;

    public void AddStudentAtBeginning(int rollNumber, string name, int age, char grade){
        Student newStudent = new Student(rollNumber, name, age, grade);
        newStudent.Next = head;
        head = newStudent;
    }

    public void AddStudentAtEnd(int rollNumber, string name, int age, char grade){
        Student newStudent = new Student(rollNumber, name, age, grade);
        if (head == null){
            head = newStudent;
            return;
        }
        Student temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }

    public void AddStudentAtPosition(int rollNumber, string name, int age, char grade, int position){
        if (position < 1){
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1){
            AddStudentAtBeginning(rollNumber, name, age, grade);
            return;
        }
        Student newStudent = new Student(rollNumber, name, age, grade);
        Student temp = head;
        for (int i = 1; temp != null && i < position - 1; i++){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Position out of range");
            return;
        }
        newStudent.Next = temp.Next;
        temp.Next = newStudent;
    }

    public void DeleteStudentByRollNumber(int rollNumber){
        if (head == null){
            Console.WriteLine("List is empty");
            return;
        }
        if (head.RollNumber == rollNumber){
            head = head.Next;
            return;
        }
        Student temp = head;
        while (temp.Next != null && temp.Next.RollNumber != rollNumber){
            temp = temp.Next;
        }
        if (temp.Next == null){
            Console.WriteLine("Student not found");
            return;
        }
        temp.Next = temp.Next.Next;
    }

    public void SearchStudentByRollNumber(int rollNumber){
        Student temp = head;
        while (temp != null){
            if (temp.RollNumber == rollNumber){
                Console.WriteLine($"Roll Number: {temp.RollNumber}, \nName: {temp.Name}, \nAge: {temp.Age}, \nGrade: {temp.Grade}\n");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }

    public void DisplayAllStudents(){
        if (head == null){
            Console.WriteLine("No students available");
            return;
        }
        Student temp = head;
        while (temp != null){
            Console.WriteLine($"Roll Number: {temp.RollNumber}, \nName: {temp.Name}, \nAge: {temp.Age}, \nGrade: {temp.Grade}\n");
            temp = temp.Next;
        }
    }

    public void UpdateStudentGrade(int rollNumber, char newGrade){
        Student temp = head;
        while (temp != null){
            if (temp.RollNumber == rollNumber){
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }
}

class Ques1{
   public static void Print(){
        StudentList list = new StudentList();
        list.AddStudentAtEnd(1, "Aditya", 19, 'C');
        list.AddStudentAtEnd(2, "Ayush", 21, 'B');
        list.AddStudentAtBeginning(3, "Shivam", 22, 'A');        
        list.AddStudentAtBeginning(4, "Vaibhav Singh", 21, 'O');        
        Console.WriteLine("===All Students===");
        list.DisplayAllStudents();


        Console.WriteLine("\n===Searching for student with Roll Number 3:===");
        list.SearchStudentByRollNumber(3);

        Console.WriteLine("\n===Updating grade for Roll Number 1:===");
        list.UpdateStudentGrade(1, 'A');

        Console.WriteLine("\n===Deleting student with Roll Number 3:===");
        list.DeleteStudentByRollNumber(3);

        Console.WriteLine("\n===All Students after deletion:===");
        list.DisplayAllStudents();
    }
}