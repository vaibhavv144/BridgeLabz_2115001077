class Ques3{

public static void CalculateMaxHandshakes()
{
    // Get input for the number of students
    Console.Write("Enter the number of students: ");
    int numberOfStudents = Convert.ToInt32(Console.ReadLine());

    // Calculate the maximum number of handshakes using the formula
    int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

    // Display the result
    Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is: {handshakes}");
}
}