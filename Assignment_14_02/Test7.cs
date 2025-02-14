class Test7{
    static void CountingSort(int[] ages, int minAge, int maxAge) {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
            count[ages[i] - minAge]++;

        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--){
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        for (int i = 0; i < ages.Length; i++)
            ages[i] = output[i];
    }

    public static void Print()
    {
        int[] studentAges = { 12, 15, 14, 10, 18, 13, 17, 11, 16, 14, 12, 10 };
        Console.WriteLine("Original Student Ages:");
        Console.WriteLine(string.Join(", ", studentAges));
        CountingSort(studentAges, 10, 18);
        Console.WriteLine("Sorted Student Ages:");
        Console.WriteLine(string.Join(", ", studentAges));
    }
}
