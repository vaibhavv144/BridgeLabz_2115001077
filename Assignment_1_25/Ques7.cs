class Ques7{
public static void CalculateBMIs_2()
{
    // Input the number of persons
    Console.Write("Enter the number of persons: ");
    int numPersons = Convert.ToInt32(Console.ReadLine());

    // Multi-dimensional array to store height, weight, and BMI
    double[][] personData = new double[numPersons, 3];
    string[] weightStatus = new string[numPersons];

    // Input height and weight for each person
    for (int i = 0; i < numPersons; i++)
    {
        Console.Write($"Enter height (in meters) for person {i + 1}: ");
        double height = Convert.ToDouble(Console.ReadLine());
        while (height <= 0)
        {
            Console.Write("Height must be positive. Please re-enter: ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        Console.Write($"Enter weight (in kg) for person {i + 1}: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        while (weight <= 0)
        {
            Console.Write("Weight must be positive. Please re-enter: ");
            weight = Convert.ToDouble(Console.ReadLine());
        }

        personData[i, 0] = height;
        personData[i, 1] = weight;

        // Calculate BMI
        double bmi = weight / (height * height);
        personData[i, 2] = bmi;

        // Determine weight status based on BMI
        if (bmi < 18.5)
        {
            weightStatus[i] = "Underweight";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            weightStatus[i] = "Normal weight";
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            weightStatus[i] = "Overweight";
        }
        else
        {
            weightStatus[i] = "Obesity";
        }
    }
    Console.WriteLine("Person\tHeight (m)\tWeight (kg)\tBMI\t	Status");
    for (int i = 0; i < numPersons; i++)
    {
        Console.WriteLine($"{i + 1}\t{personData[i, 0]:F2}\t\t{personData[i, 1]:F2}\t\t{personData[i, 2]:F2}\t\t{weightStatus[i]}");
    }
}
}