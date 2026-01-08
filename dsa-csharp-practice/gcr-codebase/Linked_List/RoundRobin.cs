using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
6. Circular Linked List: Round Robin Scheduling Algorithm
Problem Statement: Implement a round-robin CPU scheduling algorithm using a circular linked list. Each node will represent a process and contain Process ID, Burst Time, and Priority. Implement the following functionalities:
    Add a new process at the end of the circular list.
    Remove a process by Process ID after its execution.
    Simulate the scheduling of processes in a round-robin manner with a fixed time quantum.
    Display the list of processes in the circular queue after each round.
    Calculate and display the average waiting time and turn-around time for all processes.
*/

namespace Assignment.Linked_List
{
    class ProcessNode
    {
        public int ProcessId;
        public int BurstTime;
        public int RemainingTime;
        public int Priority;
        public int WaitingTime;
        public int TurnAroundTime;
        public ProcessNode Next;

        public ProcessNode(int id, int burst, int priority)
        {
            ProcessId = id;
            BurstTime = burst;
            RemainingTime = burst;
            Priority = priority;
            WaitingTime = 0;
            TurnAroundTime = 0;
            Next = this; 
        }
    }
    class RRScheduler
    {
        private ProcessNode head;
        private int processCount;

        //Add process at end
        public void AddProcess(int id, int burst, int priority)
        {
            ProcessNode newNode = new ProcessNode(id, burst, priority);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ProcessNode temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newNode;
                newNode.Next = head;
            }
            processCount++;
        }

        //Remove completed process
        private void RemoveProcess(ProcessNode prev, ProcessNode current)
        {
            if (current == head && current.Next == head)
            {
                head = null;
            }
            else
            {
                if (current == head)
                    head = head.Next;

                prev.Next = current.Next;
            }
            processCount--;
        }

        //Simulate Round Robin Scheduling
        public void Simulate(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes to schedule");
                return;
            }

            int time = 0;
            ProcessNode current = head;
            ProcessNode prev = null;

            while (processCount > 0)
            {
                DisplayProcesses();

                if (current.RemainingTime > 0)
                {
                    int execTime = Math.Min(timeQuantum, current.RemainingTime);
                    time += execTime;
                    current.RemainingTime -= execTime;

                    //Update wait time for others
                    ProcessNode temp = head;
                    do
                    {
                        if (temp != current && temp.RemainingTime > 0)
                            temp.WaitingTime += execTime;
                        temp = temp.Next;
                    } while (temp != head);

                    if (current.RemainingTime == 0)
                    {
                        current.TurnAroundTime = time;
                        RemoveProcess(prev, current);
                        current = (prev == null) ? head : prev.Next;
                        continue;
                    }
                }

                prev = current;
                current = current.Next;
            }

            DisplayAverages();
        }

        //Display current processes
        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No active processes");
                return;
            }

            ProcessNode temp = head;
            Console.WriteLine("Current Process Queue:");
            do
            {
                Console.WriteLine($"PID: {temp.ProcessId}, Remaining: {temp.RemainingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        //Display Average Times
        private void DisplayAverages()
        {
            double totalWaitTime = 0, totalTurnAroundTime = 0;
            int completed = 0;

            ProcessNode temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nAll processes completed.");
                return;
            }

            do
            {
                totalWaitTime += temp.WaitingTime;
                totalTurnAroundTime += temp.TurnAroundTime;
                completed++;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("\nScheduling Completed");
            Console.WriteLine($"Average Waiting Time: {totalWaitTime / completed}");
            Console.WriteLine($"Average Turnaround Time: {totalTurnAroundTime / completed}");
        }
    }
}
