using System;

class Test8{
    public static void Print(){
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int[] numbers = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++){
            numbers[i] = int.Parse(parts[i]);
        }

        int negativeNumber = FindFirstNegative(numbers);
        if (negativeNumber != int.MinValue){
            Console.WriteLine("The first negative number is: " + negativeNumber);
        }else{
            Console.WriteLine("No negative number in array.");
        }
    }

    public static int FindFirstNegative(int[] array){
        foreach (int number in array){
            if (number < 0){
                return number;
            }
        }
        return int.MinValue;
    }
}
