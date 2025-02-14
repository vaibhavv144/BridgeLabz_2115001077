using System;
class Test2{
    static void InsertionSort(int[] employeeIDs){
        int n = employeeIDs.Length;
        for (int i = 1; i < n; i++){
            int key = employeeIDs[i];
            int j = i - 1;
            while (j >= 0 && employeeIDs[j] > key){
                employeeIDs[j + 1] = employeeIDs[j];
                j--;
            }
            employeeIDs[j + 1] = key;
        }
    }
public static void Print(){
        int[] employeeIDs = { 105, 102, 110, 101, 108, 103 };
        Console.WriteLine("Original Employee IDs:");
        Console.WriteLine(string.Join(", ", employeeIDs));
        InsertionSort(employeeIDs);
        Console.WriteLine("Sorted Employee IDs:");
        Console.WriteLine(string.Join(", ", employeeIDs));
    }
}
