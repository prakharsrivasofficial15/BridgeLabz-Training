using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Assisted
{
    internal class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }

    class AnimalTest
    {
        static void Main()
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Dog("Buddy", 3);
            animals[1] = new Cat("Kitty", 2);
            animals[2] = new Bird("Tweety", 1);

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }
    }
}
