using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class ReadStudentsCsv
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("students.csv");

            string line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader)
                {
                    isHeader = false;
                    continue;
                }

                string[] data = line.Split(',');

                string id = data[0];
                string name = data[1];
                string age = data[2];
                string marks = data[3];

                Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}, Marks: {marks}");
            }
        }
    }
}
