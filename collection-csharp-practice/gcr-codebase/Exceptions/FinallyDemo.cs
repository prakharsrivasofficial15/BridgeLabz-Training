using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class FinallyDemo
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input");
            }
            finally
            {
                Console.WriteLine("Operation completed");
            }
        }
    }
}
