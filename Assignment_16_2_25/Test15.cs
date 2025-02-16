using System;

class Test15{
    public static void Print(){
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string[] elements = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++){
            array[i] = int.Parse(elements[i]);
        }

        Console.Write("Enter the target value to search for: ");
        int target = int.Parse(Console.ReadLine());

        int index = BinarySearch(array, target);

        if (index != -1){
            Console.WriteLine("The target " + target + " is found at index: " + index);
        }else{
            Console.WriteLine("The target " + target + " is not found in the array.");
        }
    }

    public static int BinarySearch(int[] array, int target) {
        int left = 0, right = array.Length - 1;

        while (left <= right){
            int mid = left + (right - left) / 2;

            if (array[mid] == target){
                return mid;
            }else if (array[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return -1;
    }
}


