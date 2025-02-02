using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hotel_book
    {

        private string guestName;
        private string roomType;
        private int nights;

        // Default Constructor
        public Hotel_book() : this("Unknown", "Standard", 1) { }

        // Parameterized Constructor
        public Hotel_book(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy Constructor
        public Hotel_book(Hotel_book other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        public void Display()
        {
            Console.WriteLine($"Guest: {guestName}, Room Type: {roomType}, Nights: {nights}");
        }
    }

    // Example Usage
    class Program
    {
        static void Main()
        {
            Hotel_book booking1 = new Hotel_book();  // Using default constructor
            Hotel_book booking2 = new Hotel_book("Vaibhav", "Single", 1);  // Using parameterized constructor
            Hotel_book booking3 = new Hotel_book(booking2);  // Using copy constructor

            booking1.Display();
            booking2.Display();
            booking3.Display();
        }
    }
}

