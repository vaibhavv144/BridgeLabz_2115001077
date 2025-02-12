using System;

class Item
{
    public string Name;
    public int ItemID;
    public int Quantity;
    public double Price;
    public Item Next;

    public Item(int itemID, string name, int quantity, double price)
    {
        ItemID = itemID;
        Name = name;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    private Item head;

    public void AddItemAtBeginning(int itemID, string name, int quantity, double price)
    {
        Item newItem = new Item(itemID, name, quantity, price);
        newItem.Next = head;
        head = newItem;
        Console.WriteLine($"Item '{name}' added at the beginning.");
    }

    public void AddItemAtEnd(int itemID, string name, int quantity, double price)
    {
        Item newItem = new Item(itemID, name, quantity, price);
        if (head == null)
        {
            head = newItem;
            return;
        }
        Item temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newItem;
        Console.WriteLine($"Item '{name}' added at the end.");
    }

    public void AddItemAtPosition(int itemID, string name, int quantity, double price, int position)
    {
        if (position <= 0)
        {
            AddItemAtBeginning(itemID, name, quantity, price);
            return;
        }

        Item newItem = new Item(itemID, name, quantity, price);
        Item temp = head;
        int index = 0;

        while (temp != null && index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        if (temp == null)
        {
            AddItemAtEnd(itemID, name, quantity, price);
            return;
        }

        newItem.Next = temp.Next;
        temp.Next = newItem;
        Console.WriteLine($"Item '{name}' added at position {position}.");
    }

    public void RemoveItem(int itemID)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        if (head.ItemID == itemID)
        {
            Console.WriteLine($"Item '{head.Name}' removed.");
            head = head.Next;
            return;
        }

        Item temp = head;
        while (temp.Next != null && temp.Next.ItemID != itemID)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found.");
            return;
        }

        Console.WriteLine($"Item '{temp.Next.Name}' removed.");
        temp.Next = temp.Next.Next;
    }

    public void UpdateQuantity(int itemID, int newQuantity)
    {
        Item temp = head;
        while (temp != null)
        {
            if (temp.ItemID == itemID)
            {
                temp.Quantity = newQuantity;
                Console.WriteLine($"Quantity of '{temp.Name}' updated to {newQuantity}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }

    public void SearchItem(string query)
    {
        Item temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.ItemID.ToString() == query || temp.Name.Equals(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Item Found: ID: {temp.ItemID}, Name: {temp.Name}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("Item not found.");
    }

    public void CalculateTotalValue()
    {
        double totalValue = 0;
        Item temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine($"\nTotal Inventory Value: ${totalValue:F2}");
    }

    public void SortInventoryByName(bool ascending = true)
    {
        if (head == null || head.Next == null) return;

        for (Item i = head; i != null; i = i.Next)
        {
            for (Item j = head; j.Next != null; j = j.Next)
            {
                if ((ascending && string.Compare(j.Name, j.Next.Name) > 0) ||
                    (!ascending && string.Compare(j.Name, j.Next.Name) < 0))
                {
                    Swap(j, j.Next);
                }
            }
        }
        Console.WriteLine($"\nInventory sorted by Name in {(ascending ? "Ascending" : "Descending")} order.");
    }

    public void SortInventoryByPrice(bool ascending = true)
    {
        if (head == null || head.Next == null) return;

        for (Item i = head; i != null; i = i.Next)
        {
            for (Item j = head; j.Next != null; j = j.Next)
            {
                if ((ascending && j.Price > j.Next.Price) ||
                    (!ascending && j.Price < j.Next.Price))
                {
                    Swap(j, j.Next);
                }
            }
        }
        Console.WriteLine($"\nInventory sorted by Price in {(ascending ? "Ascending" : "Descending")} order.");
    }

    private void Swap(Item a, Item b)
    {
        (a.ItemID, b.ItemID) = (b.ItemID, a.ItemID);
        (a.Name, b.Name) = (b.Name, a.Name);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }

    public void DisplayInventory()
    {
        if (head == null)
        {
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Console.WriteLine("\nCurrent Inventory:");
        Item temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.ItemID}, Name: {temp.Name}, Quantity: {temp.Quantity}, Price: {temp.Price:F2}");
            temp = temp.Next;
        }
    }
}

class Ques4
{
    public static void Print()
    {
        Inventory inventory = new Inventory();

        inventory.AddItemAtBeginning(101, "Laptop", 5, 1200);
        inventory.AddItemAtEnd(102, "Mouse", 10, 25);
        inventory.AddItemAtEnd(103, "Keyboard", 7, 50);
        inventory.AddItemAtPosition(104, "Monitor", 3, 300, 2);

        Console.WriteLine("\nDisplaying Inventory:");
        inventory.DisplayInventory();

        Console.WriteLine("\nSearching for an Item:");
        inventory.SearchItem("Keyboard");

        Console.WriteLine("\nUpdating Quantity:");
        inventory.UpdateQuantity(102, 15);

        Console.WriteLine("\nCalculating Total Inventory Value:");
        inventory.CalculateTotalValue();

        Console.WriteLine("\nSorting by Name (Ascending):");
        inventory.SortInventoryByName(true);
        inventory.DisplayInventory();

        Console.WriteLine("\nSorting by Price (Descending):");
        inventory.SortInventoryByPrice(false);
        inventory.DisplayInventory();

        Console.WriteLine("\nRemoving an Item:");
        inventory.RemoveItem(104);
        inventory.DisplayInventory();
    }
}
