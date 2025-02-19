using System;
using System.Collections.Generic;

class Test7
{
   public static void Print()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        Console.WriteLine("Union: " + string.Join(", ", GetUnion(set1, set2)));
        Console.WriteLine("Intersection: " + string.Join(", ", GetIntersection(set1, set2)));
    }

    static HashSet<int> GetUnion(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2); // Combines both sets
        return unionSet;
    }

    static HashSet<int> GetIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2); // Keeps only common elements
        return intersectionSet;
    }
}
