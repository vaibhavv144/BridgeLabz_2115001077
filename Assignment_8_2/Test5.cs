using System;
class Test5 {
    public static void Print() {
        Thermostat thermostat1 = new Thermostat(55, "On", 22.5);
        Thermostat thermostat2 = new Thermostat(58, "Off", 18.8);
        thermostat1.DisplayStatus();
        Console.WriteLine();
        thermostat2.DisplayStatus();
    }
}

// Superclass
class Device {
    public int DeviceId ;
    public string Status ;

    // Constructor
    public Device(int deviceId, string status) {
        DeviceId = deviceId;
        Status = status;
    }

    // Virtual method 
    public virtual void DisplayStatus() {
        Console.WriteLine($"Device ID: {DeviceId}");
        Console.WriteLine($"Status: {Status}");
    }
}

// Subclass
class Thermostat : Device {
    public double TemperatureSetting { get; set; }

    // Constructor
    public Thermostat(int deviceId, string status, double temperatureSetting) 
        : base(deviceId, status) {
        TemperatureSetting = temperatureSetting;
    }

    // Overriding 
    public override void DisplayStatus() {
        base.DisplayStatus();
        Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
    }
}
