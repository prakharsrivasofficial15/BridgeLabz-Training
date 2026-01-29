using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class UpdateSalaryCsv
    {
        static void Main(string[] args)
        {
            string inputFile = "employees.csv";
            string outputFile = "updated_employees.csv";

            using var writer = new StreamWriter(outputFile);

            foreach (string line in File.ReadLines(inputFile))
            {
                if (line.StartsWith("ID"))
                {
                    writer.WriteLine(line);
                    continue;
                }

                string[] data = line.Split(',');

                string id = data[0];
                string name = data[1];
                string department = data[2];
                double salary = double.Parse(data[3]);

                if (department == "IT")
                {
                    salary *= 1.10;
                }

                writer.WriteLine($"{id},{name},{department},{salary:F0}");
            }

            Console.WriteLine("Salary updated successfully");
        }
    }
}
