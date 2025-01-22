using System;

public class FeeCalculator_2
{
    // Method to calculate and display the discount amount and final discounted fee
    public static void CalculateDiscountedFee()
    {
        // Prompt the user for input
        Console.Write("Enter the fee amount (INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate discount amount
        double discount = (fee * discountPercent) / 100;

        // Calculate final fee after discount
        double discountedFee = fee - discount;

        // Display the result
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {discountedFee:F2}");
    }
}
