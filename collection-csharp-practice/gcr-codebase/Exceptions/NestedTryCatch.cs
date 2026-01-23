using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NestedTryCatch
    {
        static void Main()
        {
            try
            {
                int[] arr = { 10, 20, 30 };

                Console.Write("Enter index: ");
                int index = int.Parse(Console.ReadLine());

                Console.Write("Enter divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                try
                {
                    int value = arr[index];

                    try
                    {
                        int result = value / divisor;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid array index!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
