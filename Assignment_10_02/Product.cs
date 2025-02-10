using System;
using System.Collections.Generic;

// Interface 
interface ITaxable{
    double CalculateTax();
    string GetTaxDetails();
}

// Abstract class for product 
abstract class Product{
    private int productId;
    private string name;
    private double price;
    public int ProductId{
        get { return productId; }
        set { productId = value; }
    }
    public string Name{
        get { return name; }
        set { name = value; }
    }
    public double Price{
        get { return price; }
        set { price = value; }
    }
    // Constructor
    public Product(int id, string name, double price){
        this.ProductId = id;
        this.Name = name;
        this.Price = price;
    }

    // Abstract method 
    public abstract double CalculateDiscount();

    // Concrete method to product details
    public void DisplayDetails(){
        Console.WriteLine($"Product ID: {ProductId}, \nName: {Name}, \nPrice: {Price:C}, \nDiscount: {CalculateDiscount():C}");
    }
}

// Electronics category (Taxable)
class Electronics : Product, ITaxable{
    public Electronics(int id, string name, double price) 
        : base(id, name, price) { }

    // Implement discount (20%)
    public override double CalculateDiscount(){
        return Price * 0.20;
    }

    // Implement tax (18%)
    public double CalculateTax(){
        return Price * 0.18;
    }

    public string GetTaxDetails(){
        return $"Electronics Tax (18%): {CalculateTax():C}";
    }
}


class Clothing : Product, ITaxable{
    public Clothing(int id, string name, double price) 
        : base(id, name, price) { }

    public override double CalculateDiscount(){
        return Price * 0.15;
    }


    public double CalculateTax(){
        return Price * 0.05;
    }

    public string GetTaxDetails(){
        return $"Clothing Tax (5%): {CalculateTax():C}";
    }
}


class Groceries : Product{
    public Groceries(int id, string name, double price) 
        : base(id, name, price) { }

    public override double CalculateDiscount(){
        return Price * 0.05;
    }
}

class Test2{
    public static void Print(){
        List<Product> products = new List<Product>();
        Electronics product1 = new Electronics(124, "Laptop", 60000);
        Clothing product2 = new Clothing(165, "T-Shirt", 500);
        Groceries product3 = new Groceries(186, "Orange", 100);
        products.Add(product1);
        products.Add(product2);
        products.Add(product3);

        // Display product
        Console.WriteLine("=== Product Details ===\n");
        foreach (var product in products){
            product.DisplayDetails();
            if (product is ITaxable taxableProduct){
                Console.Write(taxableProduct.GetTaxDetails());
            }
            double discount = product.CalculateDiscount();
            double tax = (product is ITaxable taxProd) ? taxProd.CalculateTax() : 0;
            double finalPrice = product.Price - discount + tax;

            Console.WriteLine($"\nFinal Price: {finalPrice:C}\n");

        }
    }
}