using System;

public class Ques9
{
    public static void ConvertMatrixToArray()
    {
        // Prompt user to input the number of rows and columns
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns:");
        int columns = Convert.ToInt32(Console.ReadLine());

        // Declare a 2D array (matrix) and a 1D array
        int[,] matrix = new int[rows, columns];
        int[] array = new int[rows * columns];
        int index = 0;

        // Input the elements of the matrix from the user
        Console.WriteLine("\nEnter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element at [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Convert 2D matrix into 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        // Display the 2D matrix (Array)
        Console.WriteLine("\nThe 2D Array (Matrix) is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine(); // New line after each row
        }

        // Display the 1D array
        Console.WriteLine("\nThe 1D Array is:");
        foreach (var item in array)
        {
            Console.Write(item + " "); // Print each element in the 1D array
        }
        Console.WriteLine(); // Add a line break after displaying the array
    }
}
