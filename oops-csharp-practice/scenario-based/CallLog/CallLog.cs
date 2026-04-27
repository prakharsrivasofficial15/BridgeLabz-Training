using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.TelecomCallLogs
{
    internal class CallLog
    {
        public long PhoneNumber; 
        public string Message;    
        public DateTime TimeStamp;  

        // Constructor to initialize call log details
        public CallLog(long phoneNumber, string message, DateTime timeStamp)
        {
            PhoneNumber = phoneNumber;
            Message = message;
            TimeStamp = timeStamp;
        }

        // Displays call log details
        public void Display()
        {
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("Message      : " + Message);
            Console.WriteLine("Time Stamp   : " + TimeStamp);
        }
    }
}

