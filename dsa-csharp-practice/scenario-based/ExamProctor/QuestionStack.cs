using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    internal class QuestionStack
    {
        //questions array
        private int[] stack = new int[100];

        // Top of stack
        private int top = -1;

        //push question ID to stack
        public void Push(int q)
        {
            stack[++top] = q;
        }

        //Remove and return last visited question
        public int Pop()
        {
            if (top == -1) return -1;
            return stack[top--];
        }

        //see last visited question without removing
        public int Peek()
        {
            if (top == -1) return -1;
            return stack[top];
        }
    }

}
