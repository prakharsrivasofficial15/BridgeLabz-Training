using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class UsingStatement
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    string line = reader.ReadLine();
                    Console.WriteLine("First line: " + line);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}
