class Vehicle{

    static int RegistrationFee=1000;
    public String OwnerName;
    public String VehicleType;
    readonly int RegistrationNumber;

    public Vehicle(String OwnerName,int RegistrationNumber,String VehicleType){
        this.OwnerName=OwnerName;
        this.VehicleType=VehicleType;
        this.RegistrationNumber=RegistrationNumber;
    }
    public static void UpdateRegistrationFee(){
        Console.WriteLine("Enter new Fees");
        RegistrationFee=Convert.ToInt32(Console.ReadLine());

    }
    public  void DisplayDetails(){
        Console.WriteLine("Registration Fee: "+RegistrationFee);
        Console.WriteLine("Owner name: "+OwnerName);
        Console.WriteLine("Vehicle type: "+VehicleType);
        Console.WriteLine("Registration nbr: "+RegistrationNumber);
    }



}


class Test6{

static Vehicle vehicle;
public static void print(){
    
    while(true){
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Change Fees");
            Console.WriteLine("3. Display details");
            Console.WriteLine("4. Exit");
            int choice=Convert.ToInt32(Console.ReadLine());

        switch(choice){
            case 1:
                Console.WriteLine("Enter owner name");
                String ownerName=Console.ReadLine();
                Console.WriteLine("Enter Registration Number");
                int registrationNumber=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Vehicle Type");
                String vehicleType=Console.ReadLine();
                vehicle=new Vehicle(ownerName,registrationNumber,vehicleType);
                 if (vehicle is Vehicle){
                        vehicle.DisplayDetails();
                    }else{
                        Console.WriteLine("Invalid Object");
                    }
                    break;
            case 2:
                    Vehicle.UpdateRegistrationFee();
                    break;
            case 3:
                    vehicle.DisplayDetails();
                    break;
            case 4:
                    return;
                default:
                    Console.WriteLine("Invalid");
                    break;
        }
    }
}
}