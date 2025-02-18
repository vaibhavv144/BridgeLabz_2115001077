using System;
using System.Collections.Generic;

// Abstract class for all warehouse items
abstract class WarehouseItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void DisplayDetails();
}
// Electronics category
class Electronics : WarehouseItem
{
    public int WarrantyPeriod { get; set; }

    public Electronics(string name, double price, int warrantyPeriod)
        : base(name, price)
    {
        WarrantyPeriod = warrantyPeriod;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Electronics] {Name} - Rs{Price}, Warranty: {WarrantyPeriod} years");
    }
}

// Groceries category
class Groceries : WarehouseItem
{
    public DateTime ExpiryDate { get; set; }

    public Groceries(string name, double price, DateTime expiryDate)
        : base(name, price)
    {
        ExpiryDate = expiryDate;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Groceries] {Name} - Rs{Price}, Expiry: {ExpiryDate.ToShortDateString()}");
    }
}

// Furniture category
class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(string name, double price, string material)
        : base(name, price)
    {
        Material = material;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Furniture] {Name} - Rs{Price}, Material: {Material}");
    }
}
// Generic storage class that stores a list of warehouse items
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    // Method to add multiple items at once
    public void AddItems(List<T> newItems)
    {
        items.AddRange(newItems);
    }

    // Method to display all stored items
    public void DisplayAllItems()
    {
        Console.WriteLine($"\nStored {typeof(T).Name} Items:");
        foreach (var item in items)
        {
            item.DisplayDetails();
        }
    }
}
class Program
{
    static void Main()
    {
        // Create storage for different item types
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        // Create lists of items
        List<Electronics> electronicsList = new List<Electronics>
        {
            new Electronics("Laptop", 1200, 2),
            new Electronics("Smartphone", 800, 1)
        };

        List<Groceries> groceriesList = new List<Groceries>
        {
            new Groceries("Milk", 2.5, DateTime.Now.AddDays(7)),
            new Groceries("Bread", 1.5, DateTime.Now.AddDays(3))
        };

        List<Furniture> furnitureList = new List<Furniture>
        {
            new Furniture("Sofa", 500, "Leather"),
            new Furniture("Table", 200, "Wood")
        };

        // Add multiple items at once using List<T>
        electronicsStorage.AddItems(electronicsList);
        groceriesStorage.AddItems(groceriesList);
        furnitureStorage.AddItems(furnitureList);

        // Display all stored items
        electronicsStorage.DisplayAllItems();
        groceriesStorage.DisplayAllItems();
        furnitureStorage.DisplayAllItems();
    }
}
