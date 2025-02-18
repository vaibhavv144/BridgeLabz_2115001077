using System;
using System.Collections.Generic;

// Abstract base class for course types
abstract class CourseType
{
    public string CourseName { get; set; }
    public string Instructor { get; set; }

    public CourseType(string courseName, string instructor)
    {
        CourseName = courseName;
        Instructor = instructor;
    }

    public abstract void DisplayEvaluationMethod();
}

// Course type with exams as an evaluation method
class ExamCourse : CourseType
{
    public int TotalMarks { get; set; }

    public ExamCourse(string courseName, string instructor, int totalMarks)
        : base(courseName, instructor)
    {
        TotalMarks = totalMarks;
    }

    public override void DisplayEvaluationMethod()
    {
        Console.WriteLine($"[Exam Course] {CourseName} by {Instructor} - Total Marks: {TotalMarks}");
    }
}

// Course type with assignments as an evaluation method
class AssignmentCourse : CourseType
{
    public int TotalAssignments { get; set; }

    public AssignmentCourse(string courseName, string instructor, int totalAssignments)
        : base(courseName, instructor)
    {
        TotalAssignments = totalAssignments;
    }

    public override void DisplayEvaluationMethod()
    {
        Console.WriteLine($"[Assignment Course] {CourseName} by {Instructor} - Total Assignments: {TotalAssignments}");
    }
}

// Generic class to manage different types of courses
class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    // Add multiple courses to the list
    public void AddCourses(List<T> newCourses)
    {
        courses.AddRange(newCourses);
    }

    // Display all courses in the department
    public void DisplayAllCourses()
    {
        Console.WriteLine($"\nCourses Offered ({typeof(T).Name}):");
        foreach (var course in courses)
        {
            course.DisplayEvaluationMethod();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create Course objects for different departments
        Course<ExamCourse> examCourseManagement = new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourseManagement = new Course<AssignmentCourse>();

        // Create lists of courses
        List<ExamCourse> examCourses = new List<ExamCourse>
        {
            new ExamCourse("Mathematics", "Dr. Smith", 100),
            new ExamCourse("Physics", "Dr. Brown", 80)
        };

        List<AssignmentCourse> assignmentCourses = new List<AssignmentCourse>
        {
            new AssignmentCourse("Software Engineering", "Prof. Johnson", 5),
            new AssignmentCourse("Data Science", "Dr. Lee", 6)
        };

        // Add courses to respective departments
        examCourseManagement.AddCourses(examCourses);
        assignmentCourseManagement.AddCourses(assignmentCourses);

        // Display available courses
        examCourseManagement.DisplayAllCourses();
        assignmentCourseManagement.DisplayAllCourses();
    }
}
