using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Hybrid
{
    internal interface Worker
    {
        void PerformDuties();
    }

    class Person
    {
        public string Name;
        public int Id;

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }

    class Chef : Person, Worker
    {
        public Chef(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Chef is cooking food.");
        }
    }

    class Waiter : Person, Worker
    {
        public Waiter(string name, int id) : base(name, id) { }

        public void PerformDuties()
        {
            Console.WriteLine("Waiter is serving food to customers.");
        }
    }

    class RestaurantTest
    {
        static void Main()
        {
            Worker[] workers = new Worker[2];

            workers[0] = new Chef("Ravi", 101);
            workers[1] = new Waiter("Amit", 102);

            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].PerformDuties();
            }
        }
    }
}
