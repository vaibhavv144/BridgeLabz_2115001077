class Ques3{
    public static void FormatCurrentDate()
    {
        Console.WriteLine("Current Date in different formats:");
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"dd/MM/yyyy: {currentDate:dd/MM/yyyy}");
        Console.WriteLine($"yyyy-MM-dd: {currentDate:yyyy-MM-dd}");
        Console.WriteLine($"EEE, MMM dd, yyyy: {currentDate:ddd, MMM dd, yyyy}");
    }

}