using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BridgelabzTraining.senario_based.TelecomCallLogs
{
    internal class Utility
    {
        private CallLog[] callLogs;   // Array to store call logs
        private int logCount;         

        // Constructor initializes array and count
        public Utility()
        {
            callLogs = new CallLog[1];
            logCount = 0;
        }

        //increase array size when full
        private void ResizeArray()
        {
            CallLog[] resizedArray = new CallLog[callLogs.Length * 2];

            for (int i = 0; i < callLogs.Length; i++)
            {
                resizedArray[i] = callLogs[i];
            }

            callLogs = resizedArray;
        }

        //adds a new call log
        public void AddCallLog(long phoneNumber, string message, DateTime timeStamp)
        {
            if (logCount == callLogs.Length)
            {
                ResizeArray();
            }

            callLogs[logCount] = new CallLog(phoneNumber, message, timeStamp);
            logCount++;

            Console.WriteLine("Call log added successfully");
        }

        //searches call logs by keyword in message
        public void SearchByKeyword(string keyword)
        {
            bool isFound = false;

            for (int i = 0; i < logCount; i++)
            {
                if (callLogs[i].Message.Contains(keyword))
                {
                    callLogs[i].Display();
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No call logs found with this keyword");
            }
        }

        //filters call logs within a given time range
        public void FilterByTimeRange(DateTime startTime, DateTime endTime)
        {
            bool isFound = false;

            for (int i = 0; i < logCount; i++)
            {
                if (callLogs[i].TimeStamp >= startTime && callLogs[i].TimeStamp <= endTime)
                {
                    callLogs[i].Display();
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No call logs found in this time range");
            }
        }
    }
}
