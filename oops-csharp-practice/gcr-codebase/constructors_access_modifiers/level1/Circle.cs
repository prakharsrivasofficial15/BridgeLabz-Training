using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Circle Class
Write a Circle class with a radius attribute.
Use constructor chaining to initialize radius with both default and user-provided values.
 */

namespace Assignment.constructors_access_modifiers.level1
{
    internal class Circle
    {
        private double radius;

        //default constructor
        public Circle() : this(1.0)
        {
        }

        //parameterized constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        //method to display
        public void Display()
        {
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + Area);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //default constructor
            Circle circle = new Circle();
            Console.WriteLine("Default Constructor");
            circle.Display();

            //parameterized constructor
            Circle circle1 = new Circle();
            Console.WriteLine("Parameterized Constructor");
            circle1.Display();
        }
    }
}
