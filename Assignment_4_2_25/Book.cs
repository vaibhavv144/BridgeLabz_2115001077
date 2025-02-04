using System;

class Book
{
    static string BookName = "GLA Library";
    public string Title;
    public string Author;
    readonly int ISBN;
   

    // Constructor using 'this' keyword to resolve ambiguity
    public Book(string Title, string Author, int ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
       
    }
    public static void DisplayBookName(){
        Console.WriteLine(BookName);
    } 

   
    public void DisplayDetails()

    {   
        DisplayBookName();
        Console.WriteLine("Book Name : " + BookName);
        Console.WriteLine("Book Title : " + Title);
        Console.WriteLine("Author Name : " + Author);
        Console.WriteLine("ISBN Number : " + ISBN);
    }
}

class Test2
{
    public static void Print()
    {
        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. For Exit");

            int a = Convert.ToInt16(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Enter the Book Title");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter the Author Name");
                    string author = Console.ReadLine();

                    Console.WriteLine("Enter the ISBN Number");
                    int isbn = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book(title, author, isbn);

                    if (book is Book)
                    {
                        book.DisplayDetails();
                    }
                    break;

               

                case 2:
                    return;

                default:
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}
