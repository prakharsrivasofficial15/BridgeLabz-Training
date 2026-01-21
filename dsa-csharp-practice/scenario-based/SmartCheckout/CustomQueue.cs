using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    class QueueNode
    {
        public Customer data;
        public QueueNode Next;

        public QueueNode(Customer data)
        {
            this.data = data;
            this.Next = null;
        }
    }
    class CustomQueue
    {
        private QueueNode front;
        private QueueNode rear;

        public CustomQueue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(Customer customer)
        {
            QueueNode newNode = new QueueNode(customer);

            if(rear == null)
            {
                front = rear = newNode;
                return;
            }

            rear.Next = newNode;
            rear = newNode;
        }

        public Customer Dequeue()
        {
            if(front == null)
            {
                return null;
            }

            Customer data = front.data;
            front = front.Next;

            if(front == null)
            {
                rear = null;
            }
            return data;
        }

        // Peek
        public Customer Peek()
        {
            if (front == null)
                return null;

            return front.data;
        }

        // Check empty
        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
