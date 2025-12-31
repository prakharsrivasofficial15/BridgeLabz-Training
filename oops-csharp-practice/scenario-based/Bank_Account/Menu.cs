using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bank_Account
{
    internal class Menu
    {
        public static void Start()
        {
            Manager manager = new Manager();

            Console.WriteLine("Initialize users first");
            manager.InputUsers();

            while (true)
            {
                Console.WriteLine("WELCOME TO ICBI BANK");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManagerMenu(manager);
                        break;

                    case 2:
                        UserMenu(manager);
                        break;

                    case 3:
                        Console.WriteLine("Thank you for banking with us");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // ---------------- MANAGER MENU ----------------

        static void ManagerMenu(Manager manager)
        {
            while (true)
            {
                Console.WriteLine("\n--- MANAGER MENU ---");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Remove User");
                Console.WriteLine("3. List Users");
                Console.WriteLine("4. Update User Name");
                Console.WriteLine("5. Back");
                Console.Write("Choose option: ");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        manager.AddUser();
                        break;

                    case 2:
                        manager.RemoveUser();
                        break;

                    case 3:
                        manager.ListUsers();
                        break;

                    case 4:
                        Console.Write("Enter Account Number: ");
                        int acc = int.Parse(Console.ReadLine());

                        Console.Write("Enter New Name: ");
                        string name = Console.ReadLine();

                        manager.UpdateUserName(acc, name);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // ---------------- USER MENU ----------------

        static void UserMenu(Manager manager)
        {
            while (true)
            {
                Console.WriteLine("\n--- USER MENU ---");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Back");
                Console.Write("Choose option: ");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        manager.CheckUserBalance();
                        break;

                    case 2:
                        manager.UpdateBalance();   // Deposit handled inside
                        break;

                    case 3:
                        manager.UpdateBalance();   // Withdraw handled inside
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}

