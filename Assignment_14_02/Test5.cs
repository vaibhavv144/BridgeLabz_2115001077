using System;

class Test5{
    static void SelectionSort(int[] scores){
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++){
            int minIndex = i;
            for (int j = i + 1; j < n; j++){
                if (scores[j] < scores[minIndex]){
                    minIndex = j;
                }
            }
            int temp = scores[i];
            scores[i] = scores[minIndex];
            scores[minIndex] = temp;
        }
    }

    public static void Print(){
        int[] examScores = { 78, 92, 45, 89, 62, 55, 91, 33 };
        Console.WriteLine("Original Exam Scores:");
        Console.WriteLine(string.Join(", ", examScores));
        SelectionSort(examScores);
        Console.WriteLine("Sorted Exam Scores:");
        Console.WriteLine(string.Join(", ", examScores));
    }
}
