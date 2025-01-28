class Ques12{
public static double[] CalculateTrigonometricFunctions(double angle)
{
    // Convert angle from degrees to radians
    double radians = Math.PI * angle / 180.0;

    // Calculate sine, cosine, and tangent
    double sine = Math.Sin(radians);
    double cosine = Math.Cos(radians);
    double tangent = Math.Tan(radians);

    // Return the results as an array
    return new double[] { sine, cosine, tangent };
}
}