using System;
class Test11 {
    public static void Print() {
        ElectricVehicle tesla = new ElectricVehicle("Tesla ", 250, 100);
        PetrolVehicle bmw = new PetrolVehicle("BMW M3", 280, 60);
        Console.WriteLine("=== Electric Vehicle1 Details ===");
        tesla.DisplayInfo();
        tesla.Charge();
        Console.WriteLine();
        Console.WriteLine("=== Petrol Vehicle1 Details ===");
        bmw.DisplayInfo();
        bmw.Refuel();
    }
}

// Superclass Vehicle1
class Vehicle1 {
    public string Model ;
    public int MaxSpeed ;

    // Constructor
    public Vehicle1(string model, int maxSpeed) {
        Model = model;
        MaxSpeed = maxSpeed;
    }

    // Virtual method 
        public virtual void DisplayInfo() {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
    }
}

// Interface IRefuelable
interface IRefuelable {
    void Refuel(); 
}

// Subclass ElectricVehicle (inherits from Vehicle1)
class ElectricVehicle : Vehicle1 {
    public int BatteryCapacity;
    // Constructor
    public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
        : base(model, maxSpeed) {
        BatteryCapacity = batteryCapacity;
    }
    public void Charge() {
        Console.WriteLine($"{Model} is charging. Battery capacity: {BatteryCapacity} kWh.");
    }

    // Overriding 
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
    }
}

// Subclass PetrolVehicle 
class PetrolVehicle : Vehicle1, IRefuelable {
    public int FuelCapacity;

    // Constructor
    public PetrolVehicle(string model, int maxSpeed, int fuelCapacity)
        : base(model, maxSpeed) {
        FuelCapacity = fuelCapacity;
    }

    // Implementing Refuel method
    public void Refuel() {
        Console.WriteLine($"{Model} is refueling. Fuel capacity: {FuelCapacity} liters.");
    }

    // Overriding 
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");
    }
}
