using System;
abstract class FoodItem{
        private string itemName;
        private double price;
        private int quantity;

        public FoodItem(string itemName, double price, int quantity) {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public string ItemName { get { return itemName; } }
        public double Price { get { return price; } }
        public int Quantity { get { return quantity; } }

        public abstract double CalculateTotalPrice();

        public virtual void GetItemDetails(){
            Console.WriteLine($"Item: {itemName}, Price: Rs.{price}, Quantity: {quantity}");
        }
    }

    interface IDiscountable{
        void ApplyDiscount(double percentage);
        double GetDiscountDetails();
    }

    class VegItem : FoodItem, IDiscountable {
        private double discount;

        public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice()  {
            return (Price * Quantity) - discount;
        }

        public void ApplyDiscount(double percentage)  {
            discount = (Price * Quantity) * (percentage / 100);
        }

        public double GetDiscountDetails()  {
            return discount;
        }
    }

    class NonVegItem : FoodItem, IDiscountable {
        private double additionalCharge = 5.0;
        private double discount;

        public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice() {
            return (Price * Quantity) + additionalCharge - discount;
        }

        public void ApplyDiscount(double percentage)  {
            discount = (Price * Quantity) * (percentage / 100);
        }

        public double GetDiscountDetails()   {
            return discount;
        }
    }

    class Test6 {
       public static void Print()  {
            List<FoodItem> foodItems = new List<FoodItem>
            {
                new VegItem("Mix Veg", 180, 2),
                new NonVegItem("Fried Rice", 120, 1)
            };

            foreach (var item in foodItems)    {
                item.GetItemDetails();
                Console.WriteLine($"Total Price before discount: Rs.{item.CalculateTotalPrice()}");
                if (item is IDiscountable discountable){
                    discountable.ApplyDiscount(10);
                    Console.WriteLine($"Discount Applied: Rs.{discountable.GetDiscountDetails()}");
                    Console.WriteLine($"Final Price: Rs.{item.CalculateTotalPrice()}");
                }
                Console.WriteLine();
           
        }
    }
}
