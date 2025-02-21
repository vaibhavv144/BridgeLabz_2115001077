using System;

class Test4 {
    public static void Print() {
        HandleArrayOperations();
    }

    private static void HandleArrayOperations() {
        try {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.Write("Enter an index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        } catch (IndexOutOfRangeException) {
            Console.WriteLine("Invalid index!");
        } catch (NullReferenceException) {
            Console.WriteLine("Array is not initialized!");
        } catch (FormatException) {
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
        } catch (Exception ex) {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
