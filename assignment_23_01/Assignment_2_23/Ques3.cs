class Ques3
{
    public static void GradeChecker()
    {
        // Prompt user to enter marks for Maths
        Console.WriteLine("Enter the Maths Marks:");
        int mathMarks = Convert.ToInt32(Console.ReadLine());

        // Prompt user to enter marks for Physics
        Console.WriteLine("Enter the Physics Marks:");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        // Prompt user to enter marks for Chemistry
        Console.WriteLine("Enter the Chemistry Marks:");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        // Calculate the total marks
        int totalMarks = mathMarks + physicsMarks + chemistryMarks;

        // Calculate the average marks
        double averageMarks = (double)totalMarks / 3.0;

        // Determine the grade based on the average marks
        if (averageMarks >= 80)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: A");
        }
        else if (averageMarks >= 70)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: B");
        }
        else if (averageMarks >= 60)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: C");
        }
        else if (averageMarks >= 50)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: D");
        }
        else if (averageMarks >= 40)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: E");
        }
        else
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: R");
        }
    }
}
