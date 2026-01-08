using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
3. Circular Linked List: Task Scheduler
Problem Statement: Create a task scheduler using a circular linked list. Each node in the list represents a task with Task ID, Task Name, Priority, and Due Date. Implement the following functionalities:
    Add a task at the beginning, end, or at a specific position in the circular list.
    Remove a task by Task ID.
    View the current task and move to the next task in the circular list.
    Display all tasks in the list starting from the head node.
    Search for a task by Priority.
*/

namespace Assignment.Linked_List
{
    class TaskNode
    {
        public int TaskId;
        public string TaskName;
        public string Priority;
        public string DueDate;
        public TaskNode Next;

        public TaskNode(int taskId, string taskName, string priority, string dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = this;
        }
    }

    class Task
    {
        private TaskNode head;
        private TaskNode current;

        // Add at Beginning
        public void AddAtBeginning(int id, string name, string priority, string dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newNode;
                return;
            }

            TaskNode last = head;
            while (last.Next != head)
                last = last.Next;

            newNode.Next = head;
            last.Next = newNode;
            head = newNode;
        }

        // Add at End
        public void AddAtEnd(int id, string name, string priority, string dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newNode;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Add at Specific Position
        public void AddAtPosition(int position, int id, string name, string priority, string dueDate)
        {
            TaskNode newNode = new TaskNode(id, name, priority, dueDate);
            if (head == null || position <= 1)
            {
                AddAtBeginning(id, name, priority, dueDate);
                return;
            }

            TaskNode temp = head;
            int count = 1;

            while (count < position - 1 && temp.Next != head)
            {
                temp = temp.Next;
                count++;
            }

            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        // Remove by Task ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty");
                return;
            }

            TaskNode temp = head;
            TaskNode prev = null;

            do
            {
                if (temp.TaskId == id)
                {
                    if (temp == head && head.Next == head)
                    {
                        head = current = null;
                    }
                    else if (temp == head)
                    {
                        TaskNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;

                        if (current == temp)
                            current = head;
                    }
                    else
                    {
                        prev.Next = temp.Next;

                        if (current == temp)
                            current = temp.Next;
                    }

                    Console.WriteLine("Task removed successfully");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Task not found");
        }


        // View Current Task and Move to Next
        public void ViewNextTask()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            Console.WriteLine($"ID: {current.TaskId}, Name: {current.TaskName}, Priority: {current.Priority}, Due: {current.DueDate}");
            current = current.Next;
        }

        // Display All Tasks
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            do
            {
                Console.WriteLine($"ID: {temp.TaskId}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due: {temp.DueDate}");
                temp = temp.Next;
            } while (temp != head);
        }

        // Search by Priority
        public void SearchByPriority(string priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available");
                return;
            }

            TaskNode temp = head;
            bool found = false;

            do
            {
                if (temp.Priority.Equals(priority, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {temp.TaskId}, Name: {temp.TaskName}, Due: {temp.DueDate}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No tasks found with this priority");
        }
    }

    class Program
    {
        static void Main()
        {
            Task scheduler = new Task();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nTask Scheduler");
                Console.WriteLine("1. Add Task at Beginning");
                Console.WriteLine("2. Add Task at End");
                Console.WriteLine("3. Add Task at Specific Position");
                Console.WriteLine("4. Remove Task by ID");
                Console.WriteLine("5. View Current Task & Move Next");
                Console.WriteLine("6. Display All Tasks");
                Console.WriteLine("7. Search Task by Priority");
                Console.WriteLine("8. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Task ID: ");
                        int id1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Task Name: ");
                        string name1 = Console.ReadLine();

                        Console.Write("Enter Priority: ");
                        string p1 = Console.ReadLine();

                        Console.Write("Enter Due Date: ");
                        string d1 = Console.ReadLine();

                        scheduler.AddAtBeginning(id1, name1, p1, d1);
                        Console.WriteLine("Task added at beginning");
                        break;

                    case 2:
                        Console.Write("Enter Task ID: ");
                        int id2 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Task Name: ");
                        string name2 = Console.ReadLine();

                        Console.Write("Enter Priority: ");
                        string p2 = Console.ReadLine();

                        Console.Write("Enter Due Date: ");
                        string d2 = Console.ReadLine();

                        scheduler.AddAtEnd(id2, name2, p2, d2);
                        Console.WriteLine("Task added at end");
                        break;

                    case 3:
                        Console.Write("Enter Position: ");
                        int pos = int.Parse(Console.ReadLine());

                        Console.Write("Enter Task ID: ");
                        int id3 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Task Name: ");
                        string name3 = Console.ReadLine();

                        Console.Write("Enter Priority: ");
                        string p3 = Console.ReadLine();

                        Console.Write("Enter Due Date: ");
                        string d3 = Console.ReadLine();

                        scheduler.AddAtPosition(pos, id3, name3, p3, d3);
                        Console.WriteLine("Task added at position " + pos);
                        break;

                    case 4:
                        Console.Write("Enter Task ID to remove: ");
                        int rid = int.Parse(Console.ReadLine());
                        scheduler.RemoveById(rid);
                        break;

                    case 5:
                        scheduler.ViewNextTask();
                        break;

                    case 6:
                        scheduler.DisplayAll();
                        break;

                    case 7:
                        Console.Write("Enter Priority to search: ");
                        string sp = Console.ReadLine();
                        scheduler.SearchByPriority(sp);
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

