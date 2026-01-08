using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
4. Singly Linked List: Inventory Management System
Problem Statement: Design an inventory management system using a singly linked list where each node stores information about an item such as Item Name, Item ID, Quantity, and Price. Implement the following functionalities:
    Add an item at the beginning, end, or at a specific position.
    Remove an item based on Item ID.
    Update the quantity of an item by Item ID.
    Search for an item based on Item ID or Item Name.
    Calculate and display the total value of inventory (Sum of Price * Quantity for each item).
    Sort the inventory based on Item Name or Price in ascending or descending order.
*/

namespace Assignment.Linked_List
{
    class ItemNode
    {
        public int ItemId;
        public string ItemName;
        public int Quantity;
        public double Price;
        public ItemNode Next;

        public ItemNode(int id, string name, int qty, double price)
        {
            ItemId = id;
            ItemName = name;
            Quantity = qty;
            Price = price;
            Next = null;
        }
    }
    class InventoryLL
    {
        private ItemNode head;

        //Add at Beginning
        public void AddAtBeginning(int id, string name, int qty, double price)
        {
            ItemNode newNode = new ItemNode(id, name, qty, price);
            newNode.Next = head;
            head = newNode;
        }

        //Add at End
        public void AddAtEnd(int id, string name, int qty, double price)
        {
            ItemNode newNode = new ItemNode(id, name, qty, price);

            if (head == null)
            {
                head = newNode;
                return;
            }

            ItemNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        //Add at Specific Position
        public void AddAtPosition(int position, int id, string name, int qty, double price)
        {
            if (position == 1)
            {
                AddAtBeginning(id, name, qty, price);
                return;
            }

            ItemNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            ItemNode newNode = new ItemNode(id, name, qty, price);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        //Remove by Item ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            if (head.ItemId == id)
            {
                head = head.Next;
                Console.WriteLine("Item removed");
                return;
            }

            ItemNode temp = head;
            while (temp.Next != null && temp.Next.ItemId != id)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Item not found");
                return;
            }

            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed");
        }

        //Update Quantity
        public void UpdateQuantity(int id, int newQty)
        {
            ItemNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    temp.Quantity = newQty;
                    Console.WriteLine("Quantity updated");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item not found");
        }

        //Search by ID or Name
        public void SearchByIdOrName(int? id, string name)
        {
            ItemNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if ((id != null && temp.ItemId == id) ||
                    (!string.IsNullOrEmpty(name) && temp.ItemName == name))
                {
                    DisplayItem(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("Item not found");
        }

        //Total Inventory Value
        public void DisplayTotalValue()
        {
            double total = 0;
            ItemNode temp = head;

            while (temp != null)
            {
                total += temp.Price * temp.Quantity;
                temp = temp.Next;
            }

            Console.WriteLine($"Total Inventory Value: {total}");
        }


        // Display All Items
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            ItemNode temp = head;
            while (temp != null)
            {
                DisplayItem(temp);
                temp = temp.Next;
            }
        }

        private void DisplayItem(ItemNode item)
        {
            Console.WriteLine($"ID: {item.ItemId}, Name: {item.ItemName}, Qty: {item.Quantity}, Price: {item.Price}");
        }
    }
    class Inventory
    {
        static void Main()
        {
            InventoryLL inventory = new InventoryLL();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Item at Beginning");
                Console.WriteLine("2. Add Item at End");
                Console.WriteLine("3. Add Item at Specific Position");
                Console.WriteLine("4. Remove Item by ID");
                Console.WriteLine("5. Update Item Quantity");
                Console.WriteLine("6. Search Item by ID");
                Console.WriteLine("7. Search Item by Name");
                Console.WriteLine("8. Display All Items");
                Console.WriteLine("9. Display Total Inventory Value");
                Console.WriteLine("10. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item ID: ");
                        int id1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Item Name: ");
                        string name1 = Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        int qty1 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Price: ");
                        double price1 = double.Parse(Console.ReadLine());

                        inventory.AddAtBeginning(id1, name1, qty1, price1);
                        Console.WriteLine("Item added at beginning");
                        break;

                    case 2:
                        Console.Write("Enter Item ID: ");
                        int id2 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Item Name: ");
                        string name2 = Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        int qty2 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Price: ");
                        double price2 = double.Parse(Console.ReadLine());

                        inventory.AddAtEnd(id2, name2, qty2, price2);
                        Console.WriteLine("Item added at end");
                        break;

                    case 3:
                        Console.Write("Enter Position: ");
                        int pos = int.Parse(Console.ReadLine());

                        Console.Write("Enter Item ID: ");
                        int id3 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Item Name: ");
                        string name3 = Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        int qty3 = int.Parse(Console.ReadLine());

                        Console.Write("Enter Price: ");
                        double price3 = double.Parse(Console.ReadLine());

                        inventory.AddAtPosition(pos, id3, name3, qty3, price3);
                        Console.WriteLine("Item added at position " + pos);
                        break;

                    case 4:
                        Console.Write("Enter Item ID to remove: ");
                        int rid = int.Parse(Console.ReadLine());
                        inventory.RemoveById(rid);
                        break;

                    case 5:
                        Console.Write("Enter Item ID: ");
                        int uid = int.Parse(Console.ReadLine());

                        Console.Write("Enter New Quantity: ");
                        int newQty = int.Parse(Console.ReadLine());

                        inventory.UpdateQuantity(uid, newQty);
                        break;

                    case 6:
                        Console.Write("Enter Item ID to search: ");
                        int sid = int.Parse(Console.ReadLine());
                        inventory.SearchByIdOrName(sid, null);
                        break;

                    case 7:
                        Console.Write("Enter Item Name to search: ");
                        string sname = Console.ReadLine();
                        inventory.SearchByIdOrName(null, sname);
                        break;

                    case 8:
                        inventory.DisplayAll();
                        break;

                    case 9:
                        inventory.DisplayTotalValue();
                        break;

                    case 10:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }
}
