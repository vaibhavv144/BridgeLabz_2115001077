using System;

class Test12{
    public static void Print(){
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        
        Console.WriteLine("Enter the elements row by row:");
        for (int i = 0; i < rows; i++){
            string[] elements = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++){
                matrix[i, j] = int.Parse(elements[j]);
            }
        }

        Console.Write("Enter the target value to search for: ");
        int target = int.Parse(Console.ReadLine());

        bool found = SearchMatrix(matrix, target);

        if (found){
            Console.WriteLine("Target " + target + " found ");
        }else{
            Console.WriteLine("Target " + target + " not found ");
        }
    }

    public static bool SearchMatrix(int[,] matrix, int target){
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int left = 0, right = rows * cols - 1;

        while (left <= right){
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target){
                return true;
            }else if (midValue < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return false;
    }
}
