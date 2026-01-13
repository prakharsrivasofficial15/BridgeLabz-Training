using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 2: Compare StringBuilder Performance
Problem: Write a program that compares the performance of StringBuilder for concatenating strings multiple times. 
*/

namespace Linear__and_Binary_Search
{
    class ComparePerformance
    {
        static void Main(string[] args)
        {
            int iterations = 100000;
            Stopwatch sw = new Stopwatch();

            // String
            string str = "";
            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                str += "test";
            }
            sw.Stop();
            Console.WriteLine("String time: " + sw.ElapsedMilliseconds + " ms");

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            sw.Restart();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("test");
            }
            sw.Stop();
            Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
