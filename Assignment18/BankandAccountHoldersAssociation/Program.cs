using System;

using BankandAccountHoldersAssociation;

class Program
{
    static void Main()
    {
        Bank bank1 = new Bank("PNB");
        Bank bank2 = new Bank("SBI");

        bank1.openAccount("Somesh", 1000);


        Customer vaibhav = new Customer("Vaibhav", bank2, 1000);
        Customer aditya = new Customer("Aditya", bank1, 2000);

        vaibhav.viewBalance();
        aditya.viewBalance();

    }
}