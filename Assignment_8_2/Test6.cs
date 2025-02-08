using System;
class Test6 {
    public static void Print() {
       
        Order order = new Order(2158, "2025-02-08");
        ShippedOrder shippedOrder = new ShippedOrder(2540, "2025-02-07", "AVCD123");
        DeliveredOrder deliveredOrder = new DeliveredOrder(1455, "2025-02-05", "VWX1632", "2025-02-10");

        // Displaying order details
        Console.WriteLine("=== Order Details ===");
        order.DisplayOrderDetails();
        Console.WriteLine();

        Console.WriteLine("=== Shipped Order Details ===");
        shippedOrder.DisplayOrderDetails();
        Console.WriteLine();

        Console.WriteLine("=== Delivered Order Details ===");
        deliveredOrder.DisplayOrderDetails();
    }
}

// Base Class: Order
class Order {
    public int OrderId ;
    public string OrderDate;

    // Constructor
    public Order(int orderId, string orderDate) {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    // Virtual 
    public virtual string GetOrderStatus() {
        return "Order Placed";
    }

    public virtual void DisplayOrderDetails() {
        Console.WriteLine($"Order ID: {OrderId}");
        Console.WriteLine($"Order Date: {OrderDate}");
        Console.WriteLine($"Status: {GetOrderStatus()}");
    }
}

// Subclass ShippedOrder (Extends Order)
class ShippedOrder : Order {
    public string TrackingNumber ;

    // Constructor
    public ShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate) {
        TrackingNumber = trackingNumber;
    }

    // Overriding 
    public override string GetOrderStatus() {
        return "Order Shipped";
    }

    public override void DisplayOrderDetails() {
        base.DisplayOrderDetails();
        Console.WriteLine($"Tracking Number: {TrackingNumber}");
    }
}

// Subclass DeliveredOrder (Extends ShippedOrder)
class DeliveredOrder : ShippedOrder {
    public string DeliveryDate ;

    // Constructor
    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber) {
        DeliveryDate = deliveryDate;
    }

    // Overriding 
    public override string GetOrderStatus() {
        return "Order Delivered";
    }

    public override void DisplayOrderDetails() {
        base.DisplayOrderDetails();
        Console.WriteLine($"Delivery Date: {DeliveryDate}");
    }
}
