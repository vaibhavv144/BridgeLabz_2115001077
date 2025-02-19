using System;
using System.Collections.Generic;

class Test8
{
    static void Print()          
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        Console.WriteLine("Symmetric Difference: " + string.Join(", ", GetSymmetricDifference(set1, set2)));
    }

    static HashSet<int> GetSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> symDiff = new HashSet<int>(set1);
        symDiff.SymmetricExceptWith(set2); // Removes common elements and keeps unique ones
        return symDiff;
    }
}
