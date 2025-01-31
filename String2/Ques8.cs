class Ques8{
    public static void TemperatureConverter()
    {
        Console.WriteLine("Temperature Converter");
        Console.Write("Enter temperature value: ");
        double temp = double.Parse(Console.ReadLine());
        
        Console.Write("Convert to (C)elsius or (F)ahrenheit? Enter C or F: ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (choice == 'C')
        {
            double result = FahrenheitToCelsius(temp);
            Console.WriteLine(temp + "°F is equal to " + result + "°C");
        }
        else if (choice == 'F')
        {
            double result = CelsiusToFahrenheit(temp);
            Console.WriteLine(temp + "°C is equal to " + result + "°F");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter C or F.");
        }
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}