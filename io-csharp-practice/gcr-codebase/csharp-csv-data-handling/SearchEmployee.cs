using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class SearchEmployee
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employee name: ");
            string searchName = Console.ReadLine();

            foreach (string line in File.ReadLines("employees.csv"))
            {
                if (line.StartsWith("ID"))
                    continue;

                string[] data = line.Split(',');

                string id = data[0];
                string name = data[1];
                string department = data[2];
                string salary = data[3];

                if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Department: {department}");
                    Console.WriteLine($"Salary: {salary}");
                    return;
                }
            }

            Console.WriteLine("Employee not found");
        }
    }
}
