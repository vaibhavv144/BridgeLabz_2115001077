using System;

class Movie{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Prev;
    public Movie Next;

    public Movie(string title, string director, int year, double rating){
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Prev = null;
        Next = null;
    }
}

class MovieList{
    private Movie head;
    private Movie tail;

    public void AddMovieAtBeginning(string title, string director, int year, double rating){
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null){
            head = tail = newMovie;
            return;
        }
        newMovie.Next = head;
        head.Prev = newMovie;
        head = newMovie;
    }

    public void AddMovieAtEnd(string title, string director, int year, double rating){
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null){
            head = tail = newMovie;
            return;
        }
        tail.Next = newMovie;
        newMovie.Prev = tail;
        tail = newMovie;
    }

    public void AddMovieAtPosition(string title, string director, int year, double rating, int position){
        if (position < 1){
            Console.WriteLine("Invalid position");
            return;
        }
        if (position == 1){
            AddMovieAtBeginning(title, director, year, rating);
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++){
            temp = temp.Next;
        }
        if (temp == null || temp.Next == null){
            AddMovieAtEnd(title, director, year, rating);
            return;
        }
        newMovie.Next = temp.Next;
        newMovie.Prev = temp;
        temp.Next.Prev = newMovie;
        temp.Next = newMovie;
    }

    public void RemoveMovieByTitle(string title){
        Movie temp = head;
        while (temp != null && temp.Title != title){
            temp = temp.Next;
        }
        if (temp == null){
            Console.WriteLine("Movie not found");
            return;
        }
        if (temp == head){
            head = head.Next;
            if (head != null) head.Prev = null;
        }
        else if (temp == tail){
            tail = tail.Prev;
            tail.Next = null;
        }
        else{
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }
    }

    public void SearchMovieByDirectorOrRating(string director, double rating){
        Movie temp = head;
        while (temp != null){
            if (temp.Director == director || temp.Rating == rating){
                Console.WriteLine($"Title: {temp.Title}, \nDirector: {temp.Director}, \nYear: {temp.Year}, \nRating: {temp.Rating}\n");
            }
            temp = temp.Next;
        }
    }

    public void DisplayMoviesForward(){
        Movie temp = head;
        while (temp != null){
            Console.WriteLine($"Title: {temp.Title}, \nDirector: {temp.Director}, \nYear: {temp.Year}, \nRating: {temp.Rating}\n");
            temp = temp.Next;
        }
    }

    public void DisplayMoviesReverse(){
        Movie temp = tail;
        while (temp != null){
            Console.WriteLine($"Title: {temp.Title}, \nDirector: {temp.Director}, \nYear: {temp.Year}, \nRating: {temp.Rating}\n");
            temp = temp.Prev;
        }
    }

    public void UpdateMovieRating(string title, double newRating){
        Movie temp = head;
        while (temp != null){
            if (temp.Title == title){
                temp.Rating = newRating;
                Console.WriteLine("Rating updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found");
    }
}

class Ques2{
   public static void Print(){
        MovieList list = new MovieList();
        list.AddMovieAtEnd("Fighter", "Siddharth Anand", 2024, 8.4);
        list.AddMovieAtEnd("Animal", "Sandeep Reddy Vanga", 2024, 8.8);
        list.AddMovieAtBeginning("Hanuman", "Prasanth Varma", 2024, 8.6);
        list.AddMovieAtBeginning("Dunki", "Rajkumar Hiraniii", 2024, 8.2);

        Console.WriteLine("===All Movies===");
        list.DisplayMoviesForward();

        Console.WriteLine("\n===Searching for movies by Rajkumar Hirani or rating 8.4===");
        list.SearchMovieByDirectorOrRating("Rajkumar Hirani", 8.4);

        Console.WriteLine("\n===Updating rating for Dunki:===");
        list.UpdateMovieRating("Dunki", 8.4);

        Console.WriteLine("\n===Removing movie Dunki:===");
        list.RemoveMovieByTitle("Dunki");

        Console.WriteLine("\n===All Movies after deletion (Forward Order):===");
        list.DisplayMoviesForward();
        
        Console.WriteLine("\n===All Movies after deletion (Reverse Order):===");
        list.DisplayMoviesReverse();
    }
}