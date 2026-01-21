using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    class CustomHashMap
    {
        private Item[] table;
        private int size;

        public CustomHashMap(int size)
        {
            this.size = size;
            table = new Item[size];
        }

        // Hash function
        private int Hash(string key)
        {
            int sum = 0;
            for (int i = 0; i < key.Length; i++)
            {
                sum += key[i];
            }
            return sum % size;
        }

        // Insert item
        public void Insert(Item item)
        {
            int index = Hash(item.ItemName);

            while (table[index] != null)
            {
                index = (index + 1) % size;
            }

            table[index] = item;
        }

        // Search item
        public Item Search(string itemName)
        {
            int index = Hash(itemName);
            int startIndex = index;

            while (table[index] != null)
            {
                if (table[index].ItemName == itemName)
                    return table[index];

                index = (index + 1) % size;

                if (index == startIndex)
                    break;
            }

            return null;
        }

        // Update stock
        public bool UpdateStock(string itemName, int quantity)
        {
            Item item = Search(itemName);

            if (item == null || item.Stock < quantity)
                return false;

            item.Stock -= quantity;
            return true;
        }

        // Display stock
        public void Display()
        {
            for (int i = 0; i < size; i++)
            {
                if (table[i] != null)
                {
                    System.Console.WriteLine(table[i].ItemName + " | Price: " + table[i].Price + " | Stock: " + table[i].Stock);
                }
            }
        }
    }
}
