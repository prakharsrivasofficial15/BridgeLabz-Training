using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Singly Linked List: Student Record Management
Problem Statement: Create a program to manage student records using a singly linked list. Each node will store information about a student, including their Roll Number, Name, Age, and Grade. Implement the following operations:
    Add a new student record at the beginning, end, or at a specific position.
    Delete a student record by Roll Number.
    Search for a student record by Roll Number.
    Display all student records.
    Update a student's grade based on their Roll Number.
*/

namespace Assignment.Linked_List
{
    class StudentNode
    {
        public int RollNo;
        public string Name;
        public int Age;
        public string Grade;
        public StudentNode Next;

        public StudentNode(int rollNo, string name, int age, string grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
    class StudentLL
    {
        private StudentNode head;

        //Add at Beginning
        public void AddAtBeginning(int rollNo, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        //Add at End
        public void AddAtEnd(int rollNo, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        //Add at Specific Position
        public void AddAtPosition(int position, int rollNo, string name, int age, string grade)
        {
            if (position == 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }

            StudentNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        //Delete by Roll Number
        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.RollNo == rollNo)
            {
                head = head.Next;
                Console.WriteLine("Student record deleted");
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null && temp.Next.RollNo != rollNo)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted");
        }

        //Search by Roll Number
        public void Search(int rollNo)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    Console.WriteLine($"Found: {temp.RollNo}, {temp.Name}, {temp.Age}, {temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }

        //Update Grade
        public void UpdateGrade(int rollNo, string newGrade)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Student not found");
        }

        //Display Records
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No student records available");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"RollNo: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
        
    }

    class Student
    {
        static void Main()
        {
            StudentLL list = new StudentLL();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nStudent Record Management");
                Console.WriteLine("1. Add Student at Beginning");
                Console.WriteLine("2. Add Student at End");
                Console.WriteLine("3. Add Student at Specific Position");
                Console.WriteLine("4. Delete Student by Roll No");
                Console.WriteLine("5. Search Student by Roll No");
                Console.WriteLine("6. Update Student Grade");
                Console.WriteLine("7. Display All Students");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Roll No: ");
                        int r1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string n1 = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int a1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Grade: ");
                        string g1 = Console.ReadLine();

                        list.AddAtBeginning(r1, n1, a1, g1);
                        Console.WriteLine("Student added at beginning");
                        break;

                    case 2:
                        Console.Write("Enter Roll No: ");
                        int r2 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string n2 = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int a2 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Grade: ");
                        string g2 = Console.ReadLine();

                        list.AddAtEnd(r2, n2, a2, g2);
                        Console.WriteLine("Student added at end");
                        break;

                    case 3:
                        Console.Write("Enter Position: ");
                        int pos = int.Parse(Console.ReadLine());

                        Console.Write("Enter Roll No: ");
                        int r3 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string n3 = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int a3 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Grade: ");
                        string g3 = Console.ReadLine();

                        list.AddAtPosition(pos, r3, n3, a3, g3);
                        Console.WriteLine("Student added at position " + pos);
                        break;

                    case 4:
                        Console.Write("Enter Roll No to delete: ");
                        int del = int.Parse(Console.ReadLine());
                        list.DeleteByRollNo(del);
                        break;

                    case 5:
                        Console.Write("Enter Roll No to search: ");
                        int sr = int.Parse(Console.ReadLine());
                        list.Search(sr);
                        break;

                    case 6:
                        Console.Write("Enter Roll No: ");
                        int ur = int.Parse(Console.ReadLine());

                        Console.Write("Enter New Grade: ");
                        string ng = Console.ReadLine();

                        list.UpdateGrade(ur, ng);
                        break;

                    case 7:
                        list.Display();
                        break;

                    case 8:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }


    }

}
