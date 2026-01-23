using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Division
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter denominator: ");
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
                Console.WriteLine("Error: Please enter valid numbers only");
            }
        }
    }

}
