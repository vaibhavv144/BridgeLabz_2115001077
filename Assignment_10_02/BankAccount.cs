using System;
abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public string AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        public double Balance { get { return balance; } protected set { balance = value; } }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited Rs.{amount} into {accountNumber}. New balance: Rs.{balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew Rs.{amount} from {accountNumber}. Remaining balance: Rs.{balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public abstract double CalculateInterest();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account: {accountNumber}, Holder: {holderName}, Balance: Rs.{balance}");
        }
    }

    interface ILoanable
    {
        void ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04;

        public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan of Rs.{amount} applied for savings account {AccountNumber}.");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5;
        }
    }

    class CurrentAccount : BankAccount
    {
        private double interestRate = 0.02;

        public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }
    }

    class Test4{
        public static void Print(){
            List<BankAccount> accounts = new List<BankAccount>
            {
                new SavingsAccount("S423", "Vaibhav", 50090),
                new CurrentAccount("C756", "Ayush", 10900)
            };

            foreach (var account in accounts){
                account.DisplayDetails();
                double interest = account.CalculateInterest();
                Console.WriteLine($"Calculated Interest: Rs.{interest}");
                if (account is ILoanable loanable)
                {
                    Console.WriteLine($"Loan Eligibility: Rs.{loanable.CalculateLoanEligibility()}");
                    loanable.ApplyForLoan(2000);
                }
                Console.WriteLine();
            
        }
    }
}
