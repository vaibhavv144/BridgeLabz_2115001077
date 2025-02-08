using System;
class Test8 {
    public static void Print() {
        SavingsAccount savings = new SavingsAccount(101, 5000, 4.5);
        CheckingAccount checking = new CheckingAccount(102, 3000, 1000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount(103, 10000, 12);
        Console.WriteLine("=== Savings Account ===");
        savings.DisplayAccountType();
        savings.DisplayAccountDetails();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("=== Checking Account ===");
        checking.DisplayAccountType();
        checking.DisplayAccountDetails();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("=== Fixed Deposit Account ===");
        fixedDeposit.DisplayAccountType();
        fixedDeposit.DisplayAccountDetails();
    }
}

// Base Class BankAccount
class BankAccount {
    public int AccountNumber ;
    public double Balance ;

    // Constructor
    public BankAccount(int accountNumber, double balance) {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    // Method to display account details
    public virtual void DisplayAccountDetails() {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: Rs.{Balance}");
    }

    // Virtual method 
    public virtual void DisplayAccountType() {
        Console.WriteLine("Bank Account");
    }
}

// Subclass SavingsAccount
class SavingsAccount : BankAccount {
    public double InterestRate;

    // Constructor
    public SavingsAccount(int accountNumber, double balance, double interestRate)
        : base(accountNumber, balance) {
        InterestRate = interestRate;
    }

    // Overriding 
    public override void DisplayAccountType() {
        Console.WriteLine("Savings Account");
    }

    // Overriding 
    public override void DisplayAccountDetails() {
        base.DisplayAccountDetails();
        Console.WriteLine($"Interest Rate: {InterestRate}%");
    }
}

// Subclass CheckingAccount
class CheckingAccount : BankAccount {
    public double WithdrawalLimit ;

    // Constructor
    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance) {
        WithdrawalLimit = withdrawalLimit;
    }

    // Overriding 
    public override void DisplayAccountType() {
        Console.WriteLine("Checking Account");
    }

    // Overriding 
    public override void DisplayAccountDetails() {
        base.DisplayAccountDetails();
        Console.WriteLine($"Withdrawal Limit: Rs.{WithdrawalLimit}");
    }
}

// Subclass FixedDepositAccount
class FixedDepositAccount : BankAccount {
    public int DurationInMonths ;

    // Constructor
    public FixedDepositAccount(int accountNumber, double balance, int durationInMonths)
        : base(accountNumber, balance) {
        DurationInMonths = durationInMonths;
    }

    // Overriding 
    public override void DisplayAccountType() {
        Console.WriteLine("Fixed Deposit Account");
    }

    // Overriding 
    public override void DisplayAccountDetails() {
        base.DisplayAccountDetails();
        Console.WriteLine($"Duration: {DurationInMonths} months");
    }
}

