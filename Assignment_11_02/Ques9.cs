using System;

class Ticket
{
    public int TicketID;
    public string CustomerName;
    public string MovieName;
    public int SeatNumber;
    public DateTime BookingTime;
    public Ticket Next;

    public Ticket(int ticketID, string customerName, string movieName, int seatNumber)
    {
        TicketID = ticketID;
        CustomerName = customerName;
        MovieName = movieName;
        SeatNumber = seatNumber;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

class TicketCircularLinkedList
{
    private Ticket last;

    public void AddTicket(int ticketID, string customerName, string movieName, int seatNumber)
    {
        Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber);

        if (last == null)
        {
            last = newTicket;
            last.Next = last; // Circular reference
        }
        else
        {
            newTicket.Next = last.Next;
            last.Next = newTicket;
            last = newTicket;
        }
        Console.WriteLine("Ticket booked successfully.");
    }

    public void RemoveTicket(int ticketID)
    {
        if (last == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket current = last.Next, prev = last;
        do
        {
            if (current.TicketID == ticketID)
            {
                if (current == last && current.Next == last) // Single node case
                {
                    last = null;
                }
                else
                {
                    prev.Next = current.Next;
                    if (current == last)
                        last = prev;
                }
                Console.WriteLine("Ticket removed successfully.");
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != last.Next);

        Console.WriteLine("Ticket not found.");
    }

    public void DisplayTickets()
    {
        if (last == null)
        {
            Console.WriteLine("No booked tickets available.");
            return;
        }

        Ticket temp = last.Next;
        Console.WriteLine("Current Booked Tickets:");
        do
        {
            Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
            temp = temp.Next;
        } while (temp != last.Next);
    }

    public void SearchTicketByCustomer(string customerName)
    {
        if (last == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket temp = last.Next;
        bool found = false;
        do
        {
            if (temp.CustomerName == customerName)
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != last.Next);

        if (!found)
            Console.WriteLine("No tickets found for this customer.");
    }

    public void SearchTicketByMovie(string movieName)
    {
        if (last == null)
        {
            Console.WriteLine("No tickets available.");
            return;
        }

        Ticket temp = last.Next;
        bool found = false;
        do
        {
            if (temp.MovieName == movieName)
            {
                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != last.Next);

        if (!found)
            Console.WriteLine("No tickets found for this movie.");
    }

    public int CountTickets()
    {
        if (last == null)
            return 0;

        int count = 0;
        Ticket temp = last.Next;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != last.Next);

        return count;
    }
}

class Ques9
{
    public static void Print()
    {
        TicketCircularLinkedList ticketList = new TicketCircularLinkedList();

        ticketList.AddTicket(101, "Vaibhav", "Inception", 12);
        ticketList.AddTicket(102, "Siddhant", "Interstellar", 15);
        ticketList.AddTicket(103, "Shivam", "The Dark Knight", 20);

        Console.WriteLine("\nDisplaying Tickets:");
        ticketList.DisplayTickets();

        Console.WriteLine("\nSearching for tickets booked by 'Vaibhav':");
        ticketList.SearchTicketByCustomer("Vaibhav");

        Console.WriteLine("\nSearching for tickets for 'Interstellar':");
        ticketList.SearchTicketByMovie("Interstellar");

        Console.WriteLine("\nTotal tickets booked: " + ticketList.CountTickets());

        Console.WriteLine("\nRemoving Ticket ID 102:");
        ticketList.RemoveTicket(102);

        Console.WriteLine("\nFinal Ticket List:");
        ticketList.DisplayTickets();
    }
}
