using System;

class Test1{
    static void BubbleSort(int[] marks){
        int n = marks.Length;
        for (int i = 0; i < n - 1; i++){
            bool swapped = false;
            for (int j = 0; j < n - i - 1; j++){
                if (marks[j] > marks[j + 1]){
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
   public static void Print(){
        int[] marks = { 78, 45, 89, 62, 55, 91, 33 };
        Console.WriteLine("Original Marks:");
        Console.WriteLine(string.Join(", ", marks));
        BubbleSort(marks);
        Console.WriteLine("Sorted Marks:");
        Console.WriteLine(string.Join(", ", marks));
    }
}
