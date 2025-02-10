using System;
namespace ABC
{
abstract class Vehicle1{
        private string vehicleId;
        private string driverName;
        protected double ratePerKm;

        public Vehicle1(string vehicleId, string driverName, double ratePerKm){
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public string VehicleId { get { return vehicleId; } }
        public string DriverName { get { return driverName; } }

        public abstract double CalculateFare(double distance);

        public virtual void GetVehicleDetails(){
            Console.WriteLine($"Vehicle1 ID: {vehicleId}, Driver: {driverName}, Rate per km: Rs.{ratePerKm}");
        }
    }

    interface IGPS{
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    class Car : Vehicle1, IGPS{
        public Car(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance){
            return ratePerKm * distance;
        }

        public void GetCurrentLocation(){
            Console.WriteLine("Fetching current location for Car...");
        }

        public void UpdateLocation(string location){
            Console.WriteLine($"Car location updated to: {location}");
        }
    }

    class Bike : Vehicle1, IGPS{
        public Bike(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance){
            return ratePerKm * distance * 0.9;
        }

        public void GetCurrentLocation(){
            Console.WriteLine("Fetching current location for Bike...");
        }

        public void UpdateLocation(string location){
            Console.WriteLine($"Bike location updated to: {location}");
        }
    }
    class Auto : Vehicle1, IGPS{
        public Auto(string vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance){
            return ratePerKm * distance * 1.1;
        }

        public void GetCurrentLocation(){
            Console.WriteLine("Fetching current location for Auto...");
        }

        public void UpdateLocation(string location)
        {
            Console.WriteLine($"Auto location updated to: {location}");
        }
    }

    class Test8{
        public static void Print(){
            List<Vehicle1> vehicles = new List<Vehicle1>
            {
                new Car("V001", "Vaibhav Singh", 17),
                new Bike("S002", "Shivam Rajput", 8),
                new Auto("A003", "Ashish Verma", 14)
            };

            double distance = 15.0;

            foreach (var vehicle in vehicles){
                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: Rs.{vehicle.CalculateFare(distance)}");
                if (vehicle is IGPS gpsEnabled)  {
                    gpsEnabled.GetCurrentLocation();
                    gpsEnabled.UpdateLocation("Downtown");
                }
                Console.WriteLine();
            }
        }
    }
}
