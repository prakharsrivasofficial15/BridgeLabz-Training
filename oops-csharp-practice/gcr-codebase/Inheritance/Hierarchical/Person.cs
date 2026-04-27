using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Hierarchical
{
    internal class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("Role: Person");
        }
    }

    class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role: Teacher");
            Console.WriteLine("Subject: " + Subject);
        }
    }

    class Student : Person
    {
        public string Grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role: Student");
            Console.WriteLine("Grade: " + Grade);
        }
    }

    class Staff : Person
    {
        public string Department;

        public Staff(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        public override void DisplayRole()
        {
            Console.WriteLine("Role: Staff");
            Console.WriteLine("Department: " + Department);
        }
    }

    class SchoolTest
    {
        static void Main()
        {
            Person[] people = new Person[3];

            people[0] = new Teacher("Mr. Kumar", 40, "Mathematics");
            people[1] = new Student("Anita", 15, "10th Grade");
            people[2] = new Staff("Ramesh", 35, "Administration");

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Name: " + people[i].Name);
                Console.WriteLine("Age: " + people[i].Age);
                people[i].DisplayRole();
                Console.WriteLine();
            }
        }
    }
}
