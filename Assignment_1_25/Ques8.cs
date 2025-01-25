class Ques8{

    public static void ProcessStudentData()
    {
        // Input the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Declare arrays to store marks, percentages, and grades
        double[] physics = new double[numStudents];
        double[] chemistry = new double[numStudents];
        double[] maths = new double[numStudents];
        double[] percentage = new double[numStudents];
        string[] grade = new string[numStudents];

        // Input marks for each student and validate
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}:");

            // Input and validate Physics marks
            physics[i] = GetValidMarks("Physics");

            // Input and validate Chemistry marks
            chemistry[i] = GetValidMarks("Chemistry");

            // Input and validate Maths marks
            maths[i] = GetValidMarks("Maths");

            // Calculate percentage
            percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3;

            // Assign grade based on percentage
            if (percentage[i] >= 80)
                grade[i] = "A";
            else if (percentage[i] >= 70)
                grade[i] = "B";
            else if (percentage[i] >= 60)
                grade[i] = "C";
            else if (percentage[i] >= 50)
                grade[i] = "D";
            else if (percentage[i] >= 40)
                grade[i] = "E";
            else
                grade[i] = "R";
        }

        // Display results
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1} - Physics: {physics[i]}, Chemistry: {chemistry[i]}, Maths: {maths[i]}, Percentage: {percentage[i]:F2}%, Grade: {grade[i]}");
        }
    }

    // Function to input and validate marks for a subject
    public static double GetValidMarks(string subject)
    {
        double marks;
        while (true)
        {
            Console.Write($"Enter {subject} marks: ");
            marks = double.Parse(Console.ReadLine());

            if (marks < 0)
            {
                Console.WriteLine("Invalid marks. Marks cannot be negative. Please re-enter.");
            }
            else
            {
                break;
            }
        }
        return marks;
    }
}

