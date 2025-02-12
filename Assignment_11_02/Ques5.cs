using System;

class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public Book Next;
    public Book Prev;

    public Book(int bookID, string title, string author, string genre, bool isAvailable = true)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Next = Prev = null;
    }
}

class Library
{
    private Book head;
    private Book tail;
    private int bookCount = 0;

    public void AddBookAtBeginning(int bookID, string title, string author, string genre)
    {
        Book newBook = new Book(bookID, title, author, genre);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        bookCount++;
        Console.WriteLine($"Book '{title}' added at the beginning.");
    }

    public void AddBookAtEnd(int bookID, string title, string author, string genre)
    {
        Book newBook = new Book(bookID, title, author, genre);
        if (tail == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        bookCount++;
        Console.WriteLine($"Book '{title}' added at the end.");
    }

    public void AddBookAtPosition(int bookID, string title, string author, string genre, int position)
    {
        if (position <= 0)
        {
            AddBookAtBeginning(bookID, title, author, genre);
            return;
        }

        Book newBook = new Book(bookID, title, author, genre);
        Book temp = head;
        int index = 0;

        while (temp != null && index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        if (temp == null)
        {
            AddBookAtEnd(bookID, title, author, genre);
            return;
        }

        newBook.Next = temp.Next;
        newBook.Prev = temp;
        if (temp.Next != null)
            temp.Next.Prev = newBook;
        temp.Next = newBook;

        if (newBook.Next == null)
            tail = newBook;

        bookCount++;
        Console.WriteLine($"Book '{title}' added at position {position}.");
    }

    public void RemoveBook(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Book temp = head;
        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp.Prev != null)
            temp.Prev.Next = temp.Next;
        else
            head = temp.Next;

        if (temp.Next != null)
            temp.Next.Prev = temp.Prev;
        else
            tail = temp.Prev;

        bookCount--;
        Console.WriteLine($"Book '{temp.Title}' removed from the library.");
    }

    public void SearchBook(string query)
    {
        Book temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.Title.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                temp.Author.Equals(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book Found: ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {(temp.IsAvailable ? "Yes" : "No")}");
                found = true;
            }
            temp = temp.Next;
        }
        if (!found)
            Console.WriteLine("Book not found.");
    }

    public void UpdateAvailability(int bookID, bool status)
    {
        Book temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = status;
                Console.WriteLine($"Availability of '{temp.Title}' updated to {(status ? "Available" : "Not Available")}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }

    public void DisplayBooksForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\nBooks in Forward Order:");
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {(temp.IsAvailable ? "Yes" : "No")}");
            temp = temp.Next;
        }
    }

    public void DisplayBooksReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\nBooks in Reverse Order:");
        Book temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {(temp.IsAvailable ? "Yes" : "No")}");
            temp = temp.Prev;
        }
    }

    public void CountBooks()
    {
        Console.WriteLine($"\nTotal number of books in library: {bookCount}");
    }
}

class Ques5
{
   public static void Print()
    {
        Library library = new Library();

        library.AddBookAtBeginning(101, "The God of Small Things", "Arundhati Roy ", "Classic");
        library.AddBookAtEnd(102, "Midnight’s Children", "Salman Rushdie", "Fiction");
        library.AddBookAtEnd(103, "Train to Pakistan", "Khushwant Singh", "Historical Fiction");
        library.AddBookAtPosition(104, "The White Tiger", "Aravind Adiga", "Social Satire", 1);

        Console.WriteLine("\nDisplaying Books in Forward Order:");
        library.DisplayBooksForward();

        Console.WriteLine("\nDisplaying Books in Reverse Order:");
        library.DisplayBooksReverse();

        Console.WriteLine("\nSearching for a Book:");
        library.SearchBook("Train to Pakistan");

        Console.WriteLine("\nUpdating Availability:");
        library.UpdateAvailability(103, false);

        Console.WriteLine("\nCounting Books:");
        library.CountBooks();

        Console.WriteLine("\nRemoving a Book:");
        library.RemoveBook(104);

        Console.WriteLine("\nDisplaying Books After Removal:");
        library.DisplayBooksForward();
    }
}
