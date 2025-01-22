using System;

public class PurchasePriceCalculator
{
    // Method to calculate the total purchase price
    public static void CalculateTotalPrice()
    {
        // Prompt the user for the unit price
        Console.Write("Enter the unit price of the item (INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the quantity
        Console.Write("Enter the quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        double totalPrice = unitPrice * quantity;

        // Display the result
        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity {quantity} and unit price is INR {unitPrice:F2}.");
    }
}
