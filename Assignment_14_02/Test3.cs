using System;

class Test3{
    static void MergeSort(int[] prices, int left, int right){
        if (left < right){
            int mid = (left + right) / 2;
            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }

    static void Merge(int[] prices, int left, int mid, int right){
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];
        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];
        int k = left, iLeft = 0, iRight = 0;
        while (iLeft < n1 && iRight < n2){
            if (leftArray[iLeft] <= rightArray[iRight])
                prices[k++] = leftArray[iLeft++];
            else
                prices[k++] = rightArray[iRight++];
        }

        while (iLeft < n1)
            prices[k++] = leftArray[iLeft++];
        while (iRight < n2)
            prices[k++] = rightArray[iRight++];
    }

public static void Print(){
        int[] bookPrices = { 450, 200, 300, 500, 150, 400 };
        Console.WriteLine("Original Book Prices:");
        Console.WriteLine(string.Join(", ", bookPrices));
        MergeSort(bookPrices, 0, bookPrices.Length - 1);
        Console.WriteLine("Sorted Book Prices:");
        Console.WriteLine(string.Join(", ", bookPrices));
    }
}
