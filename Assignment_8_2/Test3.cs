using System;
class Test3 {
    public static void Print() {
       
        Vehicle car = new Car(200, "Petrol", 5);
        Vehicle truck = new Truck(120, "Diesel", 10000);
        Vehicle motorcycle = new Motorcycle(180, "Petrol", false);
        Vehicle[] vehicles = { car, truck, motorcycle };
        foreach (Vehicle v in vehicles) {
            v.DisplayInfo();
            Console.WriteLine(); 
        }
    }

// Superclass: Vehicle
class Vehicle {
    public int MaxSpeed;
    public string FuelType ;
    // Constructor
    public Vehicle(int maxSpeed, string fuelType) {
        MaxSpeed = maxSpeed;
        FuelType = fuelType;
    }
    // Virtual method to display vehicle info
    public virtual void DisplayInfo() {
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h,\nFuel Type: {FuelType}");
    }
}

// Subclass: Car
class Car : Vehicle {
    public int SeatCapacity ;
    // Constructor
    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType) {
        SeatCapacity = seatCapacity;
   }

    // Overriding
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Vehicle Type: Car,\nSeat Capacity: {SeatCapacity}");
    }
}

// Subclass: Truck
class Truck : Vehicle {
    public int PayloadCapacity ; 

    // Constructor
    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType) {
        PayloadCapacity = payloadCapacity;
    }

    // Overriding 
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Vehicle Type: Truck,\nPayload Capacity: {PayloadCapacity} kg");
    }
}

// Subclass: Motorcycle
class Motorcycle : Vehicle {
    public bool HasSidecar ;

    // Constructor
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType) {
        HasSidecar = hasSidecar;
    }

    // Overriding
        public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Vehicle Type: Motorcycle,\nHas Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }
}

