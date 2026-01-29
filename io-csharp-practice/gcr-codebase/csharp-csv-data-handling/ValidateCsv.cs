using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class ValidateCsv
    {
        static void Main(string[] args)
        {
            Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Regex phoneRegex = new Regex(@"^\d{10}$");

            foreach (string line in File.ReadLines("data.csv").Skip(1))
            {
                string[] data = line.Split(',');

                if (data.Length < 4)
                {
                    Console.WriteLine($"Invalid Format: {line}");
                    continue;
                }

                string email = data[2];
                string phone = data[3];

                if (!emailRegex.IsMatch(email) || !phoneRegex.IsMatch(phone))
                    Console.WriteLine($"Invalid Row: {line}");
            }
        }
    }
}
