using System;

class Test10{
    public static void Print() {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int[] rotatedArray = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++){
            rotatedArray[i] = int.Parse(parts[i]);
        }

        int Point = FindPoint(rotatedArray);
        Console.WriteLine("The index of the smallest element is: " + Point);
    }

    public static int FindPoint(int[] array){
        int left = 0;
        int right = array.Length - 1;

        while (left < right){
            int mid = left + (right - left) / 2;

            if (array[mid] > array[right]){
                left = mid + 1;
           
            }else{
                right = mid;
           
            }
        }

        return left;
    }
}
