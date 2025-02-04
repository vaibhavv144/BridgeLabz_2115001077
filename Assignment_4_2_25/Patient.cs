using System;

class Test7{
    public static void Print(){
        while (true){
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Total Patients");
            Console.WriteLine("3. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    Console.WriteLine("Enter Patient Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Patient Age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Patient Ailment:");
                    string ailment = Console.ReadLine();
                    Console.WriteLine("Enter PatientID");
                    int PatientID = Convert.ToInt32(Console.ReadLine());
                    Patient patient1 = new Patient(name, age, ailment,PatientID);

                    if (patient1 is Patient){
                        patient1.DisplayDetails();
                    }
                    break;
                case 2:
                    Patient.GetTotalPatients(); 
                    break;

                case 3:
                    return;  

                default:
                    Console.WriteLine("INVALID OPTION");
                    break;
            }
        }
    }
}

class Patient{
   static string HospitalName = "Millitary Hospital";  
    public string Name;  
    public int Age; 
    public string Ailment; 
    readonly int PatientID; 
    public static int TotalPatients;  
    public Patient(string Name, int Age, string Ailment,int PatientID){
        this.Name = Name;
        this.Age = Age;
        this.Ailment = Ailment;
        this.PatientID = PatientID; 
        TotalPatients++; 
    }
    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients  " + HospitalName + " : " + TotalPatients);
    }
    public void DisplayDetails() {
        Console.WriteLine("Hospital Name : " + HospitalName);
        Console.WriteLine("Patient Name : " + Name);
        Console.WriteLine("Patient Age : " + Age);
        Console.WriteLine("Patient Ailment : " + Ailment);
        Console.WriteLine("Patient ID : " + PatientID);
        
    }
}