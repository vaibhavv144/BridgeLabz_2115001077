public class Ques3{
     public string Title ;
    public string Author ;
    public double Price ;

    // Method to display the book details
    public void DisplayBookDetails(Ques3 book)
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + book.Title);
        Console.WriteLine("Author: " + book.Author);
        Console.WriteLine("Price: " + book.Price);
    }
}