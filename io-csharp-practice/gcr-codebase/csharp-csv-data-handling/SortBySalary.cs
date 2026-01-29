using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class SortBySalary
    {
        static void Main(string[] args)
        {
            var topEmployees =
                File.ReadLines("employees.csv")
                    .Skip(1)
                    .Select(line => line.Split(','))
                    .Select(data => new
                    {
                        Id = data[0],
                        Name = data[1],
                        Department = data[2],
                        Salary = int.Parse(data[3])
                    })
                    .OrderByDescending(emp => emp.Salary)
                    .Take(5);

            foreach (var emp in topEmployees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Salary}");
            }
        }
    }
}
