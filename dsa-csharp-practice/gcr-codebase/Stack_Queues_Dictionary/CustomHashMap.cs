using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Implement a Custom Hash Map
Problem: Design and implement a basic hash map class with operations for insertion, deletion, and retrieval.
Hint: Use an array of linked lists to handle collisions using separate chaining.
*/

namespace StackQueues
{
    class CustomHashMap<TKey, TValue>
    {
        private class Entry
        {
            public TKey Key;
            public TValue Value;
            public Entry Next;

            public Entry(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private readonly int capacity;
        private readonly Entry[] buckets;

        public CustomHashMap(int capacity = 16)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            this.capacity = capacity;
            buckets = new Entry[capacity];
        }

        private int GetBucketIndex(TKey key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key));

            return (key.GetHashCode() & 0x7FFFFFFF) % capacity;
        }

        //Insert or Update
        public void Put(TKey key, TValue value)
        {
            int index = GetBucketIndex(key);
            Entry current = buckets[index];

            while (current != null)
            {
                if (EqualityComparer<TKey>.Default.Equals(current.Key, key))
                {
                    current.Value = value;
                    return;
                }
                current = current.Next;
            }

            Entry newEntry = new Entry(key, value)
            {
                Next = buckets[index]
            };
            buckets[index] = newEntry;
        }

        //Retrieve
        public bool TryGet(TKey key, out TValue value)
        {
            int index = GetBucketIndex(key);
            Entry current = buckets[index];

            while (current != null)
            {
                if (EqualityComparer<TKey>.Default.Equals(current.Key, key))
                {
                    value = current.Value;
                    return true;
                }
                current = current.Next;
            }

            value = default;
            return false;
        }

        //Remove
        public bool Remove(TKey key)
        {
            int index = GetBucketIndex(key);
            Entry current = buckets[index];
            Entry previous = null;

            while (current != null)
            {
                if (EqualityComparer<TKey>.Default.Equals(current.Key, key))
                {
                    if (previous == null)
                        buckets[index] = current.Next;
                    else
                        previous.Next = current.Next;

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }
    }
}
