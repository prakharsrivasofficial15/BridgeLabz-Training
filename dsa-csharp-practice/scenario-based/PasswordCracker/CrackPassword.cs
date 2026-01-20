using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCracker
{
    class CrackPassword
    {
        // Characters allowed in password
        static char[] charset = {'0','1','2','3','4','5','6','7','8','9','!','@','#','$','%','^','&','*'};

        static char[] current;   // current combination being built
        static string password;  // user-entered password
        static bool found = false;

        static long steps = 0;   //time complexity
        static int maxDepth = 0; //space complexity

        static void Crack(int index, int n)
        {
            //stop if password found
            if (found) return;

            //track maximum recursion depth
            if (index > maxDepth)
                maxDepth = index;

            // Base case: full string generated
            if (index == n)
            {
                steps++; // count attempt

                string attempt = new string(current);
                Console.WriteLine(attempt);

                // Check if attempt matches password
                if (attempt == password)
                {
                    Console.WriteLine("\nPassword Found!");
                    found = true;
                }
                return;
            }

            // Try all characters at current position
            for (int i = 0; i < charset.Length; i++)
            {
                current[index] = charset[i];
                Crack(index + 1, n); // move to next position
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter password to crack: ");
            password = Console.ReadLine();

            int n = password.Length;    //password length
            current = new char[n];

            //backtracking
            Crack(0, n);

            //complexity info
            Console.WriteLine("\nComplexity:");
            Console.WriteLine("Steps (Time Complexity): " + steps);
            Console.WriteLine("Max Depth (Space Complexity): " + maxDepth);
        }
    }
}
