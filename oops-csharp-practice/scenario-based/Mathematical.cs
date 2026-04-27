using System;

/*Scenario: You are tasked with creating a utility class for mathematical operations.
Implement the following functionalities using separate methods:
● A method to calculate the factorial of a number.
● A method to check if a number is prime.
● A method to find the greatest common divisor (GCD) of two numbers.
● A method to find the nth Fibonacci number.
● Test your methods with various inputs, including edge cases like zero, one, and
negative numbers.*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario
{
    internal class Mathematical
    {
        //Factorial
        public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        //Prime Check
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        //Greatest Common Divisor (GCD)
        public static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 && b == 0)
                throw new ArgumentException("GCD is undefined when both numbers are zero.");

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        //Nth Fibonacci Number
        public static long Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Fibonacci is not defined for negative numbers.");

            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            long prev = 0;
            long current = 1;

            for (int i = 2; i <= n; i++)
            {
                long next = prev + current;
                prev = current;
                current = next;
            }

            return current;
        }

        static void Main(string[] args)
        {
            try
            {

                // Factorial
                Console.WriteLine(Mathematical.Factorial(5));
                Console.WriteLine(Mathematical.Factorial(0));

                // Prime Check
                Console.WriteLine(Mathematical.IsPrime(17));
                Console.WriteLine(Mathematical.IsPrime(1));

                // GCD
                Console.WriteLine(Mathematical.GCD(48, 18));
                Console.WriteLine(Mathematical.GCD(-24, 36));

                // Fibonacci
                Console.WriteLine(Mathematical.Fibonacci(10));
                Console.WriteLine(Mathematical.Fibonacci(0));

                // Edge case 
                Console.WriteLine("Attempting invalid operations: ");
                Console.WriteLine(Mathematical.Factorial(-5));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

    
