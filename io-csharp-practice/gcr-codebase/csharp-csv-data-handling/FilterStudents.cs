using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class FilterStudents
    {
        static void Main(string[] args)
        {
            foreach (string line in File.ReadLines("students.csv"))
            {
                if (line.StartsWith("ID"))
                    continue;

                string[] data = line.Split(',');

                string id = data[0];
                string name = data[1];
                string age = data[2];
                int marks = int.Parse(data[3]);

                if (marks > 80)
                {
                    Console.WriteLine($"{id},{name},{age},{marks}");
                }
            }
        }
    }
}
