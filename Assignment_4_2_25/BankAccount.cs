using System;

class Test1

{
    public static void Print()

    {
         while (true)
     {
            Console.WriteLine("1. Add Account");

            Console.WriteLine("2. For Total Account");

            Console.WriteLine("3. For Exit");

            int a = Convert.ToInt16(Console.ReadLine());

            switch (a)

            {       
                case 1:

                    Console.WriteLine("Enter the Account Holder Name");

                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the Account Number");

                    int AccountNumber = Convert.ToInt32(Console.ReadLine());

                    BankAccount account1 = new BankAccount(name, AccountNumber);

                    if (account1 is BankAccount)

                    {

                        account1.DisplayDetails();

                    }

                    break;

                case 2:

                    BankAccount.GetTotalAccounts();

                    break;

                case 3:

                    return;

                default:

                    Console.WriteLine("INVALID FUNCTION");

                    break;

            }



        }



    }

}

class BankAccount

{

    static string BankName = "ICICI BANK";

    public string AccountHolderName;

    readonly int AccountNumber;

    public static int TotalAccount;



    public BankAccount(string AccountHolderName, int AccountNumber)

    {

        this.AccountNumber = AccountNumber;

        this.AccountHolderName = AccountHolderName;

        TotalAccount++;



    }

    public static void GetTotalAccounts()

    {

        Console.WriteLine("Total BankAccounts in " + BankName + " : " + TotalAccount);

    }

    public void DisplayDetails()

    {

        Console.WriteLine("BankName : " + BankName);

        Console.WriteLine("AccontHolder Name : " + AccountHolderName);

        GetTotalAccounts();

        Console.WriteLine("\nAccountNumber  : " + AccountNumber);

    }

}