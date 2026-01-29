using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public int Marks;

        public override string ToString()
            => $"{Id} {Name} {Age} {Marks}";
    }

    internal class CsvToObjects
    {
        static void Main(string[] args)
        {
            List<Student> students = new();

            foreach (string line in File.ReadLines("students.csv").Skip(1))
            {
                string[] d = line.Split(',');

                students.Add(new Student
                {
                    Id = int.Parse(d[0]),
                    Name = d[1],
                    Age = int.Parse(d[2]),
                    Marks = int.Parse(d[3])
                });
            }

            students.ForEach(Console.WriteLine);
        }
    }
}
