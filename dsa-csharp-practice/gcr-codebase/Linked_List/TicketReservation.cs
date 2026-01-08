using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
9. Circular Linked List: Online Ticket Reservation System
Problem Statement: Design an online ticket reservation system using a circular linked list, where each node represents a booked ticket. Each node will store the following information: Ticket ID, Customer Name, Movie Name, Seat Number, and Booking Time. Implement the following functionalities:
    Add a new ticket reservation at the end of the circular list.
    Remove a ticket by Ticket ID.
    Display the current tickets in the list.
    Search for a ticket by Customer Name or Movie Name.
    Calculate the total number of booked tickets.
*/

namespace Assignment.Linked_List
{
    class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public string BookingTime;
        public TicketNode Next;

        public TicketNode(int id, string customer, string movie, string seat, string time)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = time;
            Next = this;
        }
    }
    class TicketReservationSystem
    {
        private TicketNode head;

        //Add ticket at end
        public void AddTicket(int id, string customer, string movie, string seat, string time)
        {
            TicketNode newNode = new TicketNode(id, customer, movie, seat, time);

            if (head == null)
            {
                head = newNode;
                return;
            }

            TicketNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        //Remove ticket by Ticket ID
        public void RemoveTicket(int id)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode current = head;
            TicketNode prev = null;

            do
            {
                if (current.TicketId == id)
                {
                    if (current == head)
                    {
                        TicketNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    Console.WriteLine("Ticket cancelled successfully");
                    return;
                }

                prev = current;
                current = current.Next;

            } while (current != head);

            Console.WriteLine("Ticket not found");
        }

        //Display all tickets
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode temp = head;
            do
            {
                Console.WriteLine(
                    $"TicketID: {temp.TicketId}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}"
                );
                temp = temp.Next;
            } while (temp != head);
        }

        //Search ticket by Customer Name or Movie Name
        public void SearchTicket(string customer, string movie)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            bool found = false;
            TicketNode temp = head;

            do
            {
                if ((!string.IsNullOrEmpty(customer) && temp.CustomerName == customer) ||
                    (!string.IsNullOrEmpty(movie) && temp.MovieName == movie))
                {
                    Console.WriteLine(
                        $"TicketID: {temp.TicketId}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}"
                    );
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No matching ticket found");
        }

        //Count total tickets
        public int CountTickets()
        {
            if (head == null)
                return 0;

            int count = 0;
            TicketNode temp = head;

            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            return count;
        }
    }
    class TicketReservation
    {
        static void Main()
        {
            TicketReservationSystem system = new TicketReservationSystem();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nTicket Reservation System");
                Console.WriteLine("1. Book Ticket");
                Console.WriteLine("2. Cancel Ticket by ID");
                Console.WriteLine("3. Display All Tickets");
                Console.WriteLine("4. Search Ticket by Customer Name");
                Console.WriteLine("5. Search Ticket by Movie Name");
                Console.WriteLine("6. Count Total Tickets");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Ticket ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Customer Name: ");
                        string customer = Console.ReadLine();

                        Console.Write("Enter Movie Name: ");
                        string movie = Console.ReadLine();

                        Console.Write("Enter Seat Number: ");
                        string seat = Console.ReadLine();

                        Console.Write("Enter Booking Time: ");
                        string time = Console.ReadLine();

                        system.AddTicket(id, customer, movie, seat, time);
                        Console.WriteLine("Ticket booked successfully");
                        break;

                    case 2:
                        Console.Write("Enter Ticket ID to cancel: ");
                        int cancelId = int.Parse(Console.ReadLine());
                        system.RemoveTicket(cancelId);
                        break;

                    case 3:
                        system.DisplayTickets();
                        break;

                    case 4:
                        Console.Write("Enter Customer Name: ");
                        string searchCustomer = Console.ReadLine();
                        system.SearchTicket(searchCustomer, null);
                        break;

                    case 5:
                        Console.Write("Enter Movie Name: ");
                        string searchMovie = Console.ReadLine();
                        system.SearchTicket(null, searchMovie);
                        break;

                    case 6:
                        Console.WriteLine("Total Tickets Booked: " + system.CountTickets());
                        break;

                    case 7:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }

}
