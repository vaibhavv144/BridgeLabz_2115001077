using System;
using System.Collections.Generic;

class User
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public User Next;

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private User head;

    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age);
        if (head == null)
            head = newUser;
        else
        {
            User temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            temp.Next = newUser;
        }
        Console.WriteLine($"User {name} added successfully.");
    }

    public void AddFriendConnection(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.FriendIDs.Contains(userID2))
            user1.FriendIDs.Add(userID2);
        if (!user2.FriendIDs.Contains(userID1))
            user2.FriendIDs.Add(userID1);

        Console.WriteLine($"Friend connection added between {user1.Name} and {user2.Name}.");
    }

    public void RemoveFriendConnection(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        user1.FriendIDs.Remove(userID2);
        user2.FriendIDs.Remove(userID1);

        Console.WriteLine($"Friend connection removed between {user1.Name} and {user2.Name}.");
    }

    public void DisplayFriends(int userID)
    {
        User user = FindUserByID(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine($"Friends of {user.Name}:");
        if (user.FriendIDs.Count == 0)
            Console.WriteLine("No friends.");
        else
        {
            foreach (int friendID in user.FriendIDs)
            {
                User friend = FindUserByID(friendID);
                if (friend != null)
                    Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
            }
        }
    }

    public void FindMutualFriends(int userID1, int userID2)
    {
        User user1 = FindUserByID(userID1);
        User user2 = FindUserByID(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = new List<int>();

        foreach (int id in user1.FriendIDs)
        {
            if (user2.FriendIDs.Contains(id))
                mutualFriends.Add(id);
        }

        Console.WriteLine($"Mutual friends between {user1.Name} and {user2.Name}:");
        if (mutualFriends.Count == 0)
            Console.WriteLine("No mutual friends.");
        else
        {
            foreach (int friendID in mutualFriends)
            {
                User friend = FindUserByID(friendID);
                if (friend != null)
                    Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
            }
        }
    }

    public void SearchUser(string query)
    {
        User temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Name.Equals(query, StringComparison.OrdinalIgnoreCase) || temp.UserID.ToString() == query)
            {
                Console.WriteLine($"User Found: ID: {temp.UserID}, Name: {temp.Name}, Age: {temp.Age}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("User not found.");
    }

    public void CountFriends()
    {
        User temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} has {temp.FriendIDs.Count} friends.");
            temp = temp.Next;
        }
    }

    private User FindUserByID(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }
}

class Ques7
{
    public static void Print()
    {
        SocialMedia socialMedia = new SocialMedia();

        socialMedia.AddUser(1, "Vaibhav", 22);
        socialMedia.AddUser(2, "Arjun", 23);
        socialMedia.AddUser(3, "Shivam", 27);
        socialMedia.AddUser(4, "Siddhant", 22);

        socialMedia.AddFriendConnection(1, 2);
        socialMedia.AddFriendConnection(1, 3);
        socialMedia.AddFriendConnection(2, 3);
        socialMedia.AddFriendConnection(2, 4);

        Console.WriteLine("\nDisplaying Friends:");
        socialMedia.DisplayFriends(1);

        Console.WriteLine("\nFinding Mutual Friends:");
        socialMedia.FindMutualFriends(1, 2);

        Console.WriteLine("\nSearching for User:");
        socialMedia.SearchUser("Charlie");

        Console.WriteLine("\nCounting Friends:");
        socialMedia.CountFriends();

        Console.WriteLine("\nRemoving Friend Connection:");
        socialMedia.RemoveFriendConnection(1, 3);
        socialMedia.DisplayFriends(1);
    }
}
