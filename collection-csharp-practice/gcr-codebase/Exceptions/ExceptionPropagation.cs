using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ExceptionPropagationExample
    {
        static void Main()
        {
            try
            {
                Method2();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }

        static void Method2()
        {
            Method1();
        }

        private static void Method1()
        {
            Method1(10);
        }

        static void Method1(int v)
        {
            int result = v / 0; // Arithmetic exception
        }
    }
}
