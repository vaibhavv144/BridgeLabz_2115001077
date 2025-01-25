class Ques2{

	public static void FindYoungestAndTallest()
{
    // Arrays to store ages and heights of the three friends
    int[] ages = new int[3];
    double[] heights = new double[3];

    // Names of the friends
    string[] names = { "Amar", "Akbar", "Anthony" };

    // Input ages and heights for the three friends
    for (int i = 0; i < 3; i++)
    {
        while (true)
        {
            try
            {
                // Input age
                Console.Write($"Enter the age of {names[i]}: ");
                ages[i] = Convert.ToInt32(Console.ReadLine());

                // Input height
                Console.Write($"Enter the height of {names[i]} (in cm): ");
                heights[i] = Convert.ToDouble(Console.ReadLine());

                // Validate input
                if (ages[i] <= 0 || heights[i] <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter positive values for age and height.");
                    continue;
                }
                break; // Exit loop if input is valid
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }
        }
    }

    // Variables to find the youngest and tallest
    int youngestIndex = 0;
    int tallestIndex = 0;

    // Loop to determine the youngest and tallest
    for (int i = 1; i < 3; i++)
    {
        if (ages[i] < ages[youngestIndex])
        {
            youngestIndex = i;
        }

        if (heights[i] > heights[tallestIndex])
        {
            tallestIndex = i;
        }
    }

    Console.WriteLine($"The youngest friend is {names[youngestIndex]}");
    Console.WriteLine($"The tallest friend is {names[tallestIndex]}");
}






}