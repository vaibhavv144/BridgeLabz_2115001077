class Ques4{
    public static void CompareDates()
    {
        Console.WriteLine("Enter first date (yyyy-MM-dd):");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter second date (yyyy-MM-dd):");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        int comparisonResult = date1.CompareTo(date2);
        if (comparisonResult < 0)
            Console.WriteLine("The first date is before the second date.");
        else if (comparisonResult > 0)
            Console.WriteLine("The first date is after the second date.");
        else
            Console.WriteLine("Both dates are the same.");
    }

}