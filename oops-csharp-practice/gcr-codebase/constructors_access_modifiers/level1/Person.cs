using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.constructors_access_modifiers.level1
{
    internal class Person
    {
        private string name;
        private int age;

        //parameterized Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //copy Constructor
        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Rahul", 25);
            Person p2 = new Person(p1); //copy constructor

            Console.WriteLine("Original Person:");
            p1.DisplayDetails();

            Console.WriteLine("\nCopied Person:");
            p2.DisplayDetails();
        }
    }
}
