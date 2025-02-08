using System;
class Test7 {
    public static void Print() {
        Course course = new Course("Java", 6);
        OnlineCourse onlineCourse = new OnlineCourse("C# ", 8, "Dotnet Tutorial", true);
        PaidOnlineCourse paidCourse = new PaidOnlineCourse("C++", 12, "PW", true, 200, 20);

        Console.WriteLine("=== General Course ===");
        course.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("=== Online Course ===");
        onlineCourse.DisplayCourseDetails();
        Console.WriteLine();

        Console.WriteLine("=== Paid Online Course ===");
        paidCourse.DisplayCourseDetails();
    }
}

// Base Class: Course
class Course {
    public string CourseName;
    public int Duration ;

    // Constructor
    public Course(string courseName, int duration) {
        CourseName = courseName;
        Duration = duration;
    }

    // Virtual 
        public virtual void DisplayCourseDetails() {
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Duration: {Duration} weeks");
    }
}

// Subclass OnlineCourse (Extends Course)
class OnlineCourse : Course {
    public string Platform ;
    public bool IsRecorded;

    // Constructor
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration) {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    // Overriding  method
    public override void DisplayCourseDetails() {
        base.DisplayCourseDetails();
        Console.WriteLine($"Platform: {Platform}");
        Console.WriteLine($"Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}

// SubclassPaidOnlineCourse (Extends OnlineCourse)
class PaidOnlineCourse : OnlineCourse {
    public double Fee;
    public double Discount;

    // Constructor
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded) {
        Fee = fee;
        Discount = discount;
    }

    // Overriding  method
    public override void DisplayCourseDetails() {
        base.DisplayCourseDetails();
        double finalFee = Fee - (Fee * Discount / 100);
        Console.WriteLine($"Fee: Rs.{Fee}");
        Console.WriteLine($"Discount: {Discount}%");
        Console.WriteLine($"Final Price:Rs. {finalFee}");
    }
}
