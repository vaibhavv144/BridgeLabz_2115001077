using System;

class Test13{
    public static void Print(){
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string[] elements = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++){
            array[i] = Convert.ToInt32(elements[i]);
        }

        Console.Write("Enter the target value to search for: ");
        int target = Convert.ToInt32(Console.ReadLine());

        int first = Find(array, target, true);
        int last = Find(array, target, false);

        if (first != -1){
            Console.WriteLine("First occurrence of " + target + " is at index: " + first);
            Console.WriteLine("Last occurrence of " + target + " is at index: " + last);
        }else{
            Console.WriteLine("Target " + target + " not found in the array.");
        }
    }

    public static int Find(int[] array, int target, bool findFirst){
        int left = 0, right = array.Length - 1, result = -1;

        while (left <= right){
            int mid = left + (right - left) / 2;

            if (array[mid] == target){
                result = mid;
                if (findFirst)
                    right = mid - 1;
                else
                    left = mid + 1;
            }else if (array[mid] < target){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return result;
    }
}
