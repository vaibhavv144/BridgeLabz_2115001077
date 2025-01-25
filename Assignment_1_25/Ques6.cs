class Ques6{

public static void CalculateBMI_1()
{
    // Input the number of persons
    Console.Write("Enter the number of persons: ");
    int numPersons = Convert.ToInt32(Console.ReadLine());

    // Arrays to store the height, weight, BMI, and weight status
    double[] heights = new double[numPersons];
    double[] weights = new double[numPersons];
    double[] bmis = new double[numPersons];
    string[] statuses = new string[numPersons];

    // Input height and weight for each person
    for (int i = 0; i < numPersons; i++)
    {
        Console.Write($"Enter height (in meters) for person {i + 1}: ");
        heights[i] = Convert.ToDouble(Console.ReadLine());

        Console.Write($"Enter weight (in kg) for person {i + 1}: ");
        weights[i] = Convert.ToDouble(Console.ReadLine());

        // Calculate BMI
        bmis[i] = weights[i] / (heights[i] * heights[i]);

        // Determine weight status based on BMI
        if (bmis[i] < 18.5)
        {
            statuses[i] = "Underweight";
        }
        else if (bmis[i] >= 18.5 && bmis[i] < 24.9)
        {
            statuses[i] = "Normal weight";
        }
        else if (bmis[i] >= 25 && bmis[i] < 29.9)
        {
            statuses[i] = "Overweight";
        }
        else
        {
            statuses[i] = "Obesity";
        }
    }

    // Display the results
    
    Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t	Status");
    for (int i = 0; i < numPersons; i++)
    {
        Console.WriteLine($"{i + 1}\t{heights[i]:F2}\t\t{weights[i]:F2}\t\t{bmis[i]:F2}\t\t{statuses[i]}");
    }
}
}