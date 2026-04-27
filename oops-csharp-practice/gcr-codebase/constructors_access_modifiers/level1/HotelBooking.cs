using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.constructors_access_modifiers.level1
{
    internal class HotelBooking
    {
        private string guestName;
        private string roomType;
        private int nights;

        //default constructor
        public HotelBooking()
        {
            guestName = "Guest";
            roomType = "Standard";
            nights = 1;
        }

        //parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        //copy constructor
        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Type: " + roomType);
            Console.WriteLine("Nights: " + nights);
        }
    }
}
