using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class ReadLargeCsv
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("large.csv");

            int count = 0;
            string line;

            while (!reader.EndOfStream)
            {
                for (int i = 0; i < 100 && (line = reader.ReadLine()) != null; i++)
                {
                    count++;
                }

                Console.WriteLine($"Processed: {count}");
            }
        }
    }
}
