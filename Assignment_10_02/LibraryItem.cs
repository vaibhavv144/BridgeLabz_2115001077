using System;
    abstract class LibraryItem{
        private string itemId;
        private string title;
        private string author;

        public LibraryItem(string itemId, string title, string author) {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        public string ItemId { get { return itemId; } }
        public string Title { get { return title; } }
        public string Author { get { return author; } }

        public abstract int GetLoanDuration();

        public virtual void GetItemDetails(){
            Console.WriteLine($"Item ID: {itemId}, Title: {title}, Author: {author}");
        }
    }

    interface IReservable{
        void ReserveItem();
        bool CheckAvailability();
    }

    class Book : LibraryItem, IReservable{
        public Book(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration(){
            return 14;
        }

        public void ReserveItem()  {
            Console.WriteLine($"Book '{Title}' has been reserved");
        }

        public bool CheckAvailability(){
            return true;
        }
    }

    class Magazine : LibraryItem{
        public Magazine(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration()  {
            return 7;
        }
    }

    class DVD : LibraryItem, IReservable  {
        public DVD(string itemId, string title, string author) : base(itemId, title, author) { }

        public override int GetLoanDuration() {
            return 5;
        }

        public void ReserveItem()  {
            Console.WriteLine($"DVD '{Title}' has been reserved.");
        }

        public bool CheckAvailability()  {
            return false;
        }
    }

    class Test5  {
        public static void Print(){
            List<LibraryItem> libraryItems = new List<LibraryItem>
            {
                new Book("S01", "ABC", "XYX"),
                new Magazine("L01", "Python", "ABC"),
                new DVD("P02", "C# Tutorials ", "PQR")
            };

            foreach (var item in libraryItems)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");
                if (item is IReservable reservable)
                {
                    reservable.ReserveItem();
                    Console.WriteLine($"Availability: {(reservable.CheckAvailability() ? "Available" : "Not Available")}");
                }
                Console.WriteLine();
            }
        }
}
