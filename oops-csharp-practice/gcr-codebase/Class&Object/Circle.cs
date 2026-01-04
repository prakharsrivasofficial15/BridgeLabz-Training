using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Class_Object
{
    internal class Circle
    {
        private double radius;

        // Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Method to calculate area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        // Method to display circle details
        public void DisplayDetails()
        {
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Circumference: " + CalculateCircumference());
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.DisplayDetails();
        }
    }
}
