using System;
class Test4{
    static void QuickSort(int[] prices, int left, int right){
        if (left < right){
            int pivotIndex = Partition(prices, left, right);
            QuickSort(prices, left, pivotIndex - 1);
            QuickSort(prices, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] prices, int left, int right){
        int pivot = prices[right];
        int i = left - 1;
        for (int j = left; j < right; j++){
            if (prices[j] < pivot){
                i++;
                (prices[i], prices[j]) = (prices[j], prices[i]);
            }
        }
        (prices[i + 1], prices[right]) = (prices[right], prices[i + 1]);
        return i + 1;
    }

   public static void Print(){
        int[] productPrices = { 450, 200, 300, 500, 150, 400 };

        Console.WriteLine("Original Product Prices:");
        Console.WriteLine(string.Join(", ", productPrices));

        QuickSort(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        Console.WriteLine(string.Join(", ", productPrices));
    }
}
