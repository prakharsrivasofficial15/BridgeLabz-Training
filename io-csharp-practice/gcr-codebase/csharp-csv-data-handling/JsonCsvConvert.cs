using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class JsonCsvConvert
    {
        static void Main(string[] args)
        {
            string jsonFile = "students.json";
            string csvFile = "students.csv";

            string jsonContent = File.ReadAllText(jsonFile);

            List<Student>? students = JsonSerializer.Deserialize<List<Student>>(jsonContent);

            if (students == null || students.Count == 0)
            {
                Console.WriteLine("No student data found in JSON");
                return;
            }

            using StreamWriter writer = new StreamWriter(csvFile);
            writer.WriteLine("Id,Name,Age,Marks");

            foreach (Student student in students)
            {
                writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Marks}");
            }

            Console.WriteLine("JSON converted to CSV successfully");
        }
    }
}
