using System;
class Product{
    static double Discount = 15; 
    public string ProductName;
    public double Price;
    public int Quantity;
    readonly int ProductID; 
    public Product(int productId, string productName, double price, int quantity){
        this.ProductID = productId;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }
    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
        Console.WriteLine("\nUpdated Discount: " + Discount + "%");
    }
    public void DisplayDetails(){
        Console.WriteLine("\nProduct Details:");
        Console.WriteLine("====================");

        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Discount: " + Discount + "%");
     
    }
  
}
class Test4{  
    static Product product;
    public static void Print(){
        while (true){
            Console.WriteLine("\n1. Add Product ");
            Console.WriteLine("2. View Product");
            Console.WriteLine("3. Update Discount Percent");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    Console.Write("Enter Product ID: ");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Product Name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter Product Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Product Quantity: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    product = new Product(productId, productName, price, quantity);
                    if (product is Product){
                        product.DisplayDetails();
                    }else{
                        Console.WriteLine("\nInvalid Object");
                    }
                    break;              
                case 2:
                    if (product == null)
                    {
                        Console.WriteLine("\nNo product available.");
                    }
                    else
                    {
                        product.DisplayDetails();
                    }
                    break;
                case 3:
                    Console.Write("\nEnter new discount percentage: ");
                    double newDiscount = Convert.ToDouble(Console.ReadLine());
                    Product.UpdateDiscount(newDiscount);
                   break;
                case 4:
                    return; 
                default:
                    Console.WriteLine("\nInvalid");
                    break;
            }
        }
    }
}