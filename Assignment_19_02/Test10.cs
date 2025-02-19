using System;
using System.Collections.Generic;

class Test10
{
    public static void Print()
    {
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> superset = new HashSet<int> { 1, 2, 3, 4 };

        Console.WriteLine("Is Subset: " + IsSubset(subset, superset));
    }

    static bool IsSubset(HashSet<int> subset, HashSet<int> superset)
    {
        return superset.IsSupersetOf(subset); // Checks if superset contains all elements of subset
    }
}
