using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProctor
{
    //node for LL in the mp
    class AnswerNode
    {
        public int Key;
        public string Value;
        public AnswerNode Next;   //next node

        public AnswerNode(int k, string v)
        {
            Key = k;
            Value = v;
        }
    }
    //hashmap to store answers
    class AnswerMap
    {
        //Array of buckets
        private AnswerNode[] buckets = new AnswerNode[10];

        private int Hash(int key) => key % 10;

        public void Put(int key, string value)
        {
            int idx = Hash(key);
            AnswerNode node = new AnswerNode(key, value);

            // If bucket empty, insert directly
            if (buckets[idx] == null)
            {
                buckets[idx] = node;
                return;
            }

            //else add to end of linked list
            AnswerNode temp = buckets[idx];
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = node;
        }

        // Get answer for a question
        public string Get(int key)
        {
            int idx = Hash(key);
            AnswerNode temp = buckets[idx];

            while (temp != null)
            {
                if (temp.Key == key) return temp.Value;
                temp = temp.Next;
            }
            return null;
        }
    }
}
