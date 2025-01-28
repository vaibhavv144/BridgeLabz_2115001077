// Question10.cs
using System;

class Ques10
{
    public void CalculateBMI()
    {
        double[,] personData = new double[10, 3];
        string[] bmiStatus = new string[10];

        // Input weight and height
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight for person {i + 1} in kg: ");
            personData[i, 0] = double.Parse(Console.ReadLine());
            Console.Write($"Enter height for person {i + 1} in cm: ");
            personData[i, 1] = double.Parse(Console.ReadLine());

            // Calculate BMI
            personData[i, 2] = CalculateBMI(personData[i, 0], personData[i, 1]);

            // Determine BMI status
            bmiStatus[i] = DetermineBMIStatus(personData[i, 2]);
        }

        // Display results
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}: Height = {personData[i, 1]} cm, Weight = {personData[i, 0]} kg, BMI = {personData[i, 2]:F2}, Status = {bmiStatus[i]}");
        }
    }

    private double CalculateBMI(double weight, double heightCm)
    {
        double heightM = heightCm / 100;
        return weight / (heightM * heightM);
    }

    private string DetermineBMIStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 24.9)
            return "Normal weight";
        else if (bmi < 29.9)
            return "Overweight";
        else
            return "Obesity";
    }
}