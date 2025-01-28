class Ques4{


	public static void CalculateRoundsForRun()
{
    // Take user input for the three sides of the triangular park
    Console.Write("Enter the length of the first side of the triangle (in meters): ");
    double side1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the length of the second side of the triangle (in meters): ");
    double side2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the length of the third side of the triangle (in meters): ");
    double side3 = Convert.ToDouble(Console.ReadLine());

    // Calculate the perimeter of the triangular park
    double perimeter = side1 + side2 + side3;

    // Total distance the athlete wants to run (in meters)
    double totalDistance = 5000; // 5 kilometers = 5000 meters

    // Calculate the number of rounds needed
    double rounds = totalDistance / perimeter;

    // Print the result
    Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} rounds to run 5 km.");
}
}