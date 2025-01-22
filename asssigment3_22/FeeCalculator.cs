using System;

public class FeeCalculator
{
    // Method to calculate and display the discount amount and final discounted fee
    public static void CalculateDiscountedFee()
    {
        // Define fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculate discount amount
        double discount = (fee * discountPercent) / 100;

        // Calculate final fee after discount
        double discountedFee = fee - discount;

        // Display the result
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {discountedFee:F2}");
    }
}
