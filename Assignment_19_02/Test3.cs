using System;
using System.Collections.Generic;

class Test3
{
    public static void RotateList(List<int> nums, int rotateBy)
    {
        int n = nums.Count;
        rotateBy = rotateBy % n; // Handle cases where rotateBy > n

        // Create a new list with rotated elements
        List<int> rotatedList = new List<int>();

        // Add elements from rotateBy index to end
        for (int i = rotateBy; i < n; i++)
        {
            rotatedList.Add(nums[i]);
        }

        // Add first part (0 to rotateBy-1) to the end
        for (int i = 0; i < rotateBy; i++)
        {
            rotatedList.Add(nums[i]);
        }

        // Print rotated list
        Console.WriteLine("Rotated List: " + string.Join(", ", rotatedList));
    }

    public static void Print()
    {
        List<int> nums = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;

        RotateList(nums, rotateBy);
    }
}
