class Ques1{
public static void CalculateSimpleInterest()
{
    // Take input from the user
    Console.Write("Enter the Principal amount: ");
    double principal = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the Rate of Interest: ");
    double rate = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter the Time (in years): ");
    double time = Convert.ToDouble(Console.ReadLine());

    // Calculate Simple Interest
    double simpleInterest = (principal * rate * time) / 100;

    // Display the result
    Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}%, and Time {time} years.");
}
}