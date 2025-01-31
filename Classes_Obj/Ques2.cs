public class Ques2{
     public double Radius;

    // Method to calculate the area of the circle
    public static double CalculateArea(Ques2 circle)
    {
        return Math.PI * Math.Pow(circle.Radius, 2);
    }

    // Method to calculate the circumference of the circle
    public static double CalculateCircumference(Ques2 circle)
    {
        return 2 * Math.PI * circle.Radius;
    }
     public static void DisplayCircleDetails(Ques2 circle)
    {
        double area = CalculateArea(circle);
        double circumference = CalculateCircumference(circle);

        Console.WriteLine("Circle Details:");
        Console.WriteLine("Radius: " + circle.Radius);
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Circumference: " + circumference);
    }
}