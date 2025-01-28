class Level1{
	
	 static void Main(string[] args){
		 
//Ques 1	 
	// Call the CalculateSimpleInterest method
    CalculateSimpleInterest();
//<--------------------------------------------------------------------------------------------------------->		 
	//Ques 2 
	// Get input for the number of students
    Console.Write("Enter the number of students: ");
    int numberOfStudents = Convert.ToInt32(Console.ReadLine());

    // Call the CalculateHandshakes method
    int handshakes = CalculateHandshakes(numberOfStudents);

    // Display the result
    Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is: {handshakes}");	 
		 
//<--------------------------------------------------------------------------------------------------------->		 
	//Ques 3
	// Call the CalculateMaxHandshakes method
    CalculateMaxHandshakes();
		 
//<--------------------------------------------------------------------------------------------------------->		 
	//Ques 4	 
	// Call the CalculateRoundsForRun method
    CalculateRoundsForRun();
		 
//<--------------------------------------------------------------------------------------------------------->
	//Ques 5 
	Console.Write("Enter a number: ");
   // int number = Convert.ToInt32(Console.ReadLine());

    // Call the CheckNumberType method
   // int result = CheckNumberType(number);

    // Print the result based on the returned value
    if (result == 1)
    {
        Console.WriteLine("The number is positive.");
    }
    else if (result == -1)
    {
        Console.WriteLine("The number is negative.");
    }
    else
    {
        Console.WriteLine("The number is zero.");
    }



//<--------------------------------------------------------------------------------------------------------->		 
	 //Ques 6
	 // Get the month and day from user input
    //Console.Write("Enter the month (1-12): ");
    //int month = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Enter the day (1-31): ");
    //int day = Convert.ToInt32(Console.ReadLine());

    // Call the IsSpringSeason method
    //bool isSpring = IsSpringSeason(month, day);

    // Print the result
    //if (isSpring)
    //{
      //  Console.WriteLine("It's a Spring Season");
    //}
    //else
    //{
      //  Console.WriteLine("Not a Spring Season");
    //}
	
//<--------------------------------------------------------------------------------------------------------->	
	//Ques7. FindSumOfNaturalNumbers();
		 
//<--------------------------------------------------------------------------------------------------------->		 
	//Ques 8	 
	// Get input from the user
   // Console.Write("Enter the first number: ");
    //int number1 = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Enter the second number: ");
    //int number2 = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Enter the third number: ");
    //int number3 = Convert.ToInt32(Console.ReadLine());

    // Call the FindSmallestAndLargest method
    //int[] result = FindSmallestAndLargest(number1, number2, number3);

    // Display the results
    //Console.WriteLine($"Smallest number: {result[0]}");
    //Console.WriteLine($"Largest number: {result[1]}");
		 
	
//<--------------------------------------------------------------------------------------------------------->	
	//Ques 9
	// Get input from the user
    //Console.Write("Enter the dividend: ");
    //int number = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Enter the divisor: ");
    //int divisor = Convert.ToInt32(Console.ReadLine());

    // Call the FindRemainderAndQuotient method
    //int[] result = FindRemainderAndQuotient(number, divisor);

    // Display the results
    //Console.WriteLine($"Quotient: {result[0]}");
    //Console.WriteLine($"Remainder: {result[1]}");
		 
//<--------------------------------------------------------------------------------------------------------->	 
		
		//Ques 10
		//Console.Write("Enter the total number of chocolates: ");
		//int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

		//Console.Write("Enter the number of children: ");
		//int numberOfChildren = Convert.ToInt32(Console.ReadLine());

		// Call the FindRemainderAndQuotient method
		//int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

		// Display the results
		//Console.WriteLine($"Each child gets: {result[0]} chocolates");
		//Console.WriteLine($"Remaining chocolates: {result[1]}");
//<--------------------------------------------------------------------------------------------------------->	 
		 
		 
		//Ques 11
		// Input temperature and wind speed
		//Console.Write("Enter the temperature in Fahrenheit: ");
		//double temperature = Convert.ToDouble(Console.ReadLine());

		//Console.Write("Enter the wind speed in mph: ");
        //double windSpeed = Convert.ToDouble(Console.ReadLine());

		// Call the CalculateWindChill method
		//double windChill = CalculateWindChill(temperature, windSpeed);

		// Display the result
		//Console.WriteLine($"The wind chill temperature is: {windChill:F2}°F");
	
//<--------------------------------------------------------------------------------------------------------->	 
	
		//Ques 12
		//double angle = 30;
        //double[] results = Ques12.CalculateTrigonometricFunctions(angle);
		// Display the results
       // Console.WriteLine($"Sine of {angle}°: {results[0]}");
        //Console.WriteLine($"Cosine of {angle}°: {results[1]}");
        //Console.WriteLine($"Tangent of {angle}°: {results[2]}");
//<--------------------------------------------------------------------------------------------------------->	 
	

	}
	
	
	
	
}