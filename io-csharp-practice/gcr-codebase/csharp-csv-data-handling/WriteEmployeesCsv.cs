using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class WriteEmployeesCsv
    {
        static void Main(String[] args)
        {
            string filePath = "employee.csv";

            string header = "ID,Name,Dept,Salary";

            string emp1 = "01,John Doe,HR,120000";
            string emp2 = "02,Jhoe Doe,HR,140000";
            string emp3 = "03,Jhor Doe,HR,160000";
            string emp4 = "04,Jhow Doe,HR,110000";
            string emp5 = "05,Jhot Doe,HR,150000";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(header);
                writer.WriteLine(emp1);
                writer.WriteLine(emp2);
                writer.WriteLine(emp3);
                writer.WriteLine(emp4);
                writer.WriteLine(emp5);
            }
            Console.WriteLine("CSV file created successfully");
        }
    }
}
