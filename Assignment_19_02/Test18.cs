using System;
using System.Collections.Generic;

class Test18{
class ShoppingCart
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();
    private LinkedList<string> productOrder = new LinkedList<string>();

    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productOrder.AddLast(product);
        }
        productPrices[product] = price;
    }

    public Dictionary<string, double> GetProductPrices() => productPrices;

    public SortedDictionary<string, double> GetSortedProductsByPrice()
    {
        return new SortedDictionary<string, double>(productPrices);
    }

    public IEnumerable<string> GetProductOrder() => productOrder;

   
}
 public static void Print()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddProduct("Apple", 1.20);
        cart.AddProduct("Banana", 0.50);
        cart.AddProduct("Orange", 0.80);
        cart.AddProduct("Apple", 1.30); // Update price

        Console.WriteLine("Product Prices:");
        foreach (var kvp in cart.GetProductPrices())
        {
            Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
        }

        Console.WriteLine("\nSorted Products by Price:");
        foreach (var kvp in cart.GetSortedProductsByPrice())
        {
            Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
        }

        Console.WriteLine("\nProduct Order:");
        foreach (var product in cart.GetProductOrder())
        {
            Console.WriteLine(product);
        }
    }

}