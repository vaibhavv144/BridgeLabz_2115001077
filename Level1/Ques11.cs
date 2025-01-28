class Ques11 {
public static double CalculateWindChill(double temperature, double windSpeed)
{
    // Calculate the wind chill temperature using the formula
    double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);

    // Return the calculated wind chill
    return windChill;
}
}