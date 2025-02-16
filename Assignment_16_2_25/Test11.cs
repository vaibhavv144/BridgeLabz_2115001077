using System;

class Test11{
    public static void Print(){
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int[] array = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++){
            array[i] = int.Parse(parts[i]);
        }

        int peakIndex = FindPeakElement(array);
        Console.WriteLine("The peak element is: " + array[peakIndex]);
    }

    public static int FindPeakElement(int[] array){
        int left = 0;
        int right = array.Length - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;

            if ((mid == 0 || array[mid] >= array[mid - 1]) && (mid == array.Length - 1 || array[mid] >= array[mid + 1])){
                return mid;
            }else if (mid < array.Length - 1 && array[mid] < array[mid + 1]){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }

        return -1;
    }
}
