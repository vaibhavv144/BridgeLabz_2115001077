using System;
using System.Collections.Generic;
using System.Linq;
class Test16{
class Policy
{
    public string PolicyNumber { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string CoverageType { get; set; }

    public Policy(string policyNumber, DateTime expiryDate, string coverageType)
    {
        PolicyNumber = policyNumber;
        ExpiryDate = expiryDate;
        CoverageType = coverageType;
    }

    public override bool Equals(object obj)
    {
        return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }
}

class InsurancePolicyManagement
{
    private HashSet<Policy> uniquePolicies = new HashSet<Policy>();
    private LinkedList<Policy> orderedPolicies = new LinkedList<Policy>();
    private SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((x, y) => x.ExpiryDate.CompareTo(y.ExpiryDate)));

    public void AddPolicy(Policy policy)
    {
        if (uniquePolicies.Add(policy))
        {
            orderedPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }
    }

    public IEnumerable<Policy> GetAllUniquePolicies() => uniquePolicies;

    public IEnumerable<Policy> GetPoliciesExpiringSoon()
    {
        DateTime now = DateTime.Now;
        return sortedPolicies.Where(p => (p.ExpiryDate - now).TotalDays <= 30);
    }

    public IEnumerable<Policy> GetPoliciesByCoverageType(string coverageType)
    {
        return uniquePolicies.Where(p => p.CoverageType == coverageType);
    }

    public IEnumerable<Policy> GetDuplicatePolicies()
    {
        return orderedPolicies.GroupBy(p => p.PolicyNumber)
                              .Where(g => g.Count() > 1)
                              .SelectMany(g => g);
    }

    public static void Print()
    {
        InsurancePolicyManagement policyManagement = new InsurancePolicyManagement();

        policyManagement.AddPolicy(new Policy("P001", DateTime.Now.AddDays(10), "Health"));
        policyManagement.AddPolicy(new Policy("P002", DateTime.Now.AddDays(40), "Auto"));
        policyManagement.AddPolicy(new Policy("P003", DateTime.Now.AddDays(5), "Home"));
        policyManagement.AddPolicy(new Policy("P001", DateTime.Now.AddDays(15), "Health")); // Duplicate

        Console.WriteLine("All Unique Policies:");
        foreach (var policy in policyManagement.GetAllUniquePolicies())
        {
            Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
        }

        Console.WriteLine("\nPolicies Expiring Soon:");
        foreach (var policy in policyManagement.GetPoliciesExpiringSoon())
        {
            Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
        }

        Console.WriteLine("\nPolicies with Coverage Type 'Health':");
        foreach (var policy in policyManagement.GetPoliciesByCoverageType("Health"))
        {
            Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
        }

        Console.WriteLine("\nDuplicate Policies:");
        foreach (var policy in policyManagement.GetDuplicatePolicies())
        {
            Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate.ToShortDateString()}");
        }
    }
}
}