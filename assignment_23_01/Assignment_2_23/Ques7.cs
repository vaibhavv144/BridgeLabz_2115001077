class Ques7{
    public static void BMICalcu(){
        // Prompt the user to enter weight in kilograms
        Console.Write("Enter weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Prompt the user to enter height in centimeters
        Console.Write("Enter height in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert height from centimeters to meters
        double heightM = heightCm / 100;

        // Calculate BMI using the formula BMI = weight / (height in meters)^2
        double bmi = weight / (heightM * heightM);

        // Display the calculated BMI value formatted to two decimal places
        Console.WriteLine($"Your BMI is: {bmi:F2}");

        // Determine weight status based on the BMI value
        if (bmi < 18.5){
            Console.WriteLine("Weight Status: Underweight");
        }else if(bmi >= 18.5 && bmi <= 24.9){
            Console.WriteLine("Weight Status: Normal weight");
        }else if(bmi >= 25 && bmi <= 39.9){
            Console.WriteLine("Weight Status: Overweight");
        }else{
            Console.WriteLine("Weight Status: Obese");
        }
    }
}
