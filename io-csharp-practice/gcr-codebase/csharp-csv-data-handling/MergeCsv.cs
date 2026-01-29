using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class MergeCsv
    {
        static void Main(string[] args)
        {
            var studentsFile1 = File.ReadLines("students1.csv").Skip(1).Select(line => line.Split(',')).Select(data => new
                    {
                        Id = data[0],
                        Name = data[1],
                        Age = data[2]
                    });

            var studentsFile2 = File.ReadLines("students2.csv").Skip(1).Select(line => line.Split(',')).Select(data => new
                    {
                        Id = data[0],
                        Marks = data[1],
                        Grade = data[2]
                    });

            var merged =
                from s1 in studentsFile1
                join s2 in studentsFile2 on s1.Id equals s2.Id
                select $"{s1.Id},{s1.Name},{s1.Age},{s2.Marks},{s2.Grade}";

            File.WriteAllLines(
                "merged.csv",
                new[] { "ID,Name,Age,Marks,Grade" }.Concat(merged)
            );

            Console.WriteLine("CSV files merged successfully");
        }
    }
}
