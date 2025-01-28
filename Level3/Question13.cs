// Question13.cs
using System;

class Question13
{
    public void MatrixOperations()
    {
        int[,] matrix1 = CreateRandomMatrix(2, 2);
        int[,] matrix2 = CreateRandomMatrix(2, 2);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);
        Console.WriteLine("Matrix 2:");
        DisplayMatrix(matrix2);

        int[,] additionResult = AddMatrices(matrix1, matrix2);
        Console.WriteLine("Addition Result:");
        DisplayMatrix(additionResult);

        int[,] subtractionResult = SubtractMatrices(matrix1, matrix2);
        Console.WriteLine("Subtraction Result:");
        DisplayMatrix(subtractionResult);

        int[,] multiplicationResult = MultiplyMatrices(matrix1, matrix2);
        Console.WriteLine("Multiplication Result:");
        DisplayMatrix(multiplicationResult);

        int[,] transposeResult = TransposeMatrix(matrix1);
        Console.WriteLine("Transpose of Matrix 1:");
        DisplayMatrix(transposeResult);

        double determinant2x2 = CalculateDeterminant2x2(matrix1);
        Console.WriteLine($"Determinant of Matrix 1: {determinant2x2}");

        double[,] inverse2x2 = CalculateInverse2x2(matrix1);
        Console.WriteLine("Inverse of Matrix 1:");
        DisplayMatrix(inverse2x2);
    }

    private int[,] CreateRandomMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
            }
        }
        return matrix;
    }

    private int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        return result;
    }

    private int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }
        return result;
    }

    private int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix2.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    private int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] transpose = new int[columns, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }
        return transpose;
    }

    private double CalculateDeterminant2x2(int[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    private double[,] CalculateInverse2x2(int[,] matrix)
    {
        double determinant = CalculateDeterminant2x2(matrix);
        if (determinant == 0)
        {
            throw new InvalidOperationException("Matrix is not invertible.");
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / determinant;
        inverse[0, 1] = -matrix[0, 1] / determinant;
        inverse[1, 0] = -matrix[1, 0] / determinant;
        inverse[1, 1] = matrix[0, 0] / determinant;

        return inverse;
    }

    private void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    private void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]:F2} ");
            }
            Console.WriteLine();
        }
    }
}