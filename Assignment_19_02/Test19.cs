using System;
using System.Collections.Generic;


static class Test19{
class BankingSystem
{
    private Dictionary<int, double> accountBalances = new Dictionary<int, double>();
    private Queue<int> withdrawalRequests = new Queue<int>();

    // Adds a new account with an initial balance
    public void AddAccount(int accountId, double initialBalance)
    {
        if (!accountBalances.ContainsKey(accountId))
        {
            accountBalances[accountId] = initialBalance;
            Console.WriteLine($"Account {accountId} added with balance ${initialBalance}");
        }
        else
        {
            Console.WriteLine($"Account {accountId} already exists.");
        }
    }

    // Requests a withdrawal for a specific account
    public void RequestWithdrawal(int accountId)
    {
        if (accountBalances.ContainsKey(accountId))
        {
            withdrawalRequests.Enqueue(accountId);
            Console.WriteLine($"Withdrawal requested for account {accountId}");
        }
        else
        {
            Console.WriteLine($"Account {accountId} does not exist.");
        }
    }

    // Processes all withdrawal requests in the order they were received
    public void ProcessWithdrawals()
    {
        while (withdrawalRequests.Count > 0)
        {
            int accountId = withdrawalRequests.Dequeue();
            // Here you can add logic to check balance and process the withdrawal
            Console.WriteLine($"Processed withdrawal for account {accountId}");
        }
    }

    // Returns accounts sorted by balance
    public SortedDictionary<int, double> GetSortedAccountsByBalance()
    {
        // Create a list of KeyValuePairs and sort by balance
        List<KeyValuePair<int, double>> sortedList = new List<KeyValuePair<int, double>>(accountBalances);
        sortedList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

        // Convert the sorted list back to a SortedDictionary
        SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>();
        foreach (var pair in sortedList)
        {
            sortedAccounts.Add(pair.Key, pair.Value);
        }

        return sortedAccounts;
    }

  
}
  public static void Print()
    {
        BankingSystem bankingSystem = new BankingSystem();

        bankingSystem.AddAccount(101, 1500.00);
        bankingSystem.AddAccount(102, 2500.00);
        bankingSystem.AddAccount(103, 500.00);

        bankingSystem.RequestWithdrawal(101);
        bankingSystem.RequestWithdrawal(103);

        Console.WriteLine("\nProcessing Withdrawals:");
        bankingSystem.ProcessWithdrawals();

        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var kvp in bankingSystem.GetSortedAccountsByBalance())
        {
            Console.WriteLine($"Account {kvp.Key}: ${kvp.Value}");
        }
    }
}