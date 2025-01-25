using System;

public class Ques6
{
    public static void CalculateMeanHeight()
    {
        // Prompt the user to enter the number of players
        Console.WriteLine("Enter the number of players in the team:");
        int playerCount = Convert.ToInt32(Console.ReadLine());

        // Validate that the number of players is positive
        if (playerCount <= 0)
        {
            Console.Error.WriteLine("Invalid number of players. Exiting program.");
            return;
        }

        // Initialize an array to store the heights of the players
        double[] playerHeights = new double[playerCount];
        double totalHeight = 0.0;

        // Loop to input the height of each player
        for (int i = 0; i < playerCount; i++)
        {
            Console.WriteLine($"Enter the height of player {i + 1} (in cm):");
            double height = Convert.ToDouble(Console.ReadLine());

            // Validate that the height is positive
            if (height <= 0)
            {
                Console.Error.WriteLine("Invalid height entered. Exiting program.");
                return;
            }

            // Store the height and add it to the total
            playerHeights[i] = height;
            totalHeight += height;
        }

        // Calculate and display the mean height
        double meanHeight = totalHeight / playerCount;
        Console.WriteLine($"\nThe mean height of the players is: {meanHeight:F2} cm.");
    }
}
