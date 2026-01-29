using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class DetectDuplicates
    {
        static void Main(string[] args)
        {
            var records = File.ReadLines("data.csv")
                    .Skip(1)
                    .Select(line => line.Split(','))
                    .Select(data => new
                    {
                        Id = data[0],
                        Name = data[1],
                        Email = data[2],
                        Phone = data[3]
                    });

            var duplicates = records.GroupBy(r => r.Id).Where(group => group.Count() > 1).SelectMany(group => group);

            foreach (var record in duplicates)
            {
                Console.WriteLine($"{record.Id},{record.Name},{record.Email},{record.Phone}");
            }
        }
    }
}
