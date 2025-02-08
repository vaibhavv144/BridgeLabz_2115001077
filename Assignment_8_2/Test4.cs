using System;
class Test4 {
    public static void Print() {
        Author book1 = new Author("Pride and Prejudice ", 1813, "Jane Austen", "A timeless romance that critiques class, marriage, and societal expectations.");
        Author book2 = new Author("Harry Potter and the Sorcerer’s Stone", 1997, "J.K. Rowling", "A magical journey of a young wizard discovering his destiny.");
        book1.DisplayInfo();
        Console.WriteLine(); 
        book2.DisplayInfo();
    }
}

// Superclass: Book
class Book {
    public string Title;
    public int PublicationYear ;

    // Constructor
    public Book(string title, int publicationYear) {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Virtual method 
        public virtual void DisplayInfo() {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}

// Subclass Author 
class Author : Book {
    public string Name ;
    public string Bio ;
    // Constructor
    public Author(string title, int publicationYear, string name, string bio) 
        : base(title, publicationYear) {
        Name = name;
        Bio = bio;
    }

    // Overriding 
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Name}");
        Console.WriteLine($"Bio: {Bio}");
    }
}
