using System;

class Test14{
    public static void Print() {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string[] elements = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++){
            array[i] = int.Parse(elements[i]);
        }

        int missing = Find(array);
        Console.WriteLine("First missing positive integer: " + missing);
    }

    public static int Find(int[] nums){
        int n = nums.Length;
        for (int i = 0; i < n; i++){
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i]){
                int temp = nums[i];
                nums[i] = nums[temp - 1];
                nums[temp - 1] = temp;
            }
        }

        for (int i = 0; i < n; i++){
            if (nums[i] != i + 1){
                return i + 1;
            }
        }

        return n + 1;
    }
}

