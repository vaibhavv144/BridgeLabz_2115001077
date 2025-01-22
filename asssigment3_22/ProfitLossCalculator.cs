using System;

public static class ProfitLossCalculator
{
    // Method to calculate and display profit and profit percentage
    public static void DisplayProfitAndPercentage()
    {
        // Define cost price and selling price
        double costPrice = 129;
        double sellingPrice = 191;

        // Calculate profit
        double profit = sellingPrice - costPrice;

        // Calculate profit percentage
        double profitPercentage = (profit / costPrice) * 100;

        // Display the result in a single print statement
        Console.WriteLine($@"
The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}
The Profit is INR {profit:F2} and the Profit Percentage is {profitPercentage:F2}%
        ");
    }
}
