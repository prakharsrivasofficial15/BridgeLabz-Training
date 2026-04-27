using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bank_Account
{
    internal class Manager
    {
        private string branchName = "GAD Nagar";
        private static string ifscCode = "ICBI8426P31";

        // 0 - AccountNumber
        // 1 - Balance
        // 2 - UserName
        // 3 - PIN
        private object[,] userData;

        public object[,] InputUsers()
        {
            Console.WriteLine("Enter number of users:");
            int n = int.Parse(Console.ReadLine());

            userData = new object[n, 4];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for User {i + 1}");

                Console.Write("Account Number: ");
                userData[i, 0] = int.Parse(Console.ReadLine());

                Console.Write("Initial Balance: ");
                userData[i, 1] = double.Parse(Console.ReadLine());

                Console.Write("User Name: ");
                userData[i, 2] = Console.ReadLine();

                Console.Write("PIN: ");
                userData[i, 3] = int.Parse(Console.ReadLine());
            }
            return userData;
        }

        private object[,] ResizeArray(object[,] oldArray, int newRows, int cols)
        {
            object[,] newArray = new object[newRows, cols];
            int oldRows = oldArray.GetLength(0);

            for (int i = 0; i < oldRows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    newArray[i, j] = oldArray[i, j];
                }
            }
            return newArray;
        }

        public void AddUser()
        {
            int rows = userData.GetLength(0);
            userData = ResizeArray(userData, rows + 1, 4);

            Console.Write("Account Number: ");
            userData[rows, 0] = int.Parse(Console.ReadLine());

            Console.Write("Initial Balance: ");
            userData[rows, 1] = double.Parse(Console.ReadLine());

            Console.Write("User Name: ");
            userData[rows, 2] = Console.ReadLine();

            Console.Write("PIN: ");
            userData[rows, 3] = int.Parse(Console.ReadLine());

            Console.WriteLine("User added successfully");
        }

        public void RemoveUser()
        {
            Console.WriteLine("Enter Account Number to remove:");
            int accNo = int.Parse(Console.ReadLine());

            for (int i = 0; i < userData.GetLength(0); i++)
            {
                if (userData[i, 0] != null && (int)userData[i, 0] == accNo)
                {
                    for (int j = 0; j < userData.GetLength(1); j++)
                    {
                        userData[i, j] = null;
                    }
                    Console.WriteLine("User removed successfully");
                    return;
                }
            }
            Console.WriteLine("User not found");
        }

        public void ListUsers()
        {
            Console.WriteLine("List of Account Holders in the Branch");

            for(int i=0; i < userData.GetLength(0); i++)
            {
                if(userData[i, 0] != null)
                {
                    Console.WriteLine("Account NUmber: " +  userData[i, 0]
                        + "Name: " + userData[i, 2] + "Balance: " + userData[i, 1]);
                }
            }
        }

        public int FindUserIndex(int accNo)
        {
            for (int i = 0; i < userData.GetLength(0); i++)
            {
                if (userData[i, 0] != null && (int)userData[i, 0] == accNo)
                    return i;
            }
            return -1;
        }

        public void UpdateUserName(int accNo, string newName)
        {
            int index = FindUserIndex(accNo);
            if (index != -1)
            {
                userData[index, 2] = newName;
                Console.WriteLine("User updated");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        private Bank bank = new Bank();

        public void UpdateBalance()
        {
            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            int index = FindUserIndex(accNo);
            if (index == -1)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.Write("Enter PIN: ");
            int inputPin = int.Parse(Console.ReadLine());

            User user = new User
            {
                AccountNumber = (int)userData[index, 0],
                Balance = (double)userData[index, 1],
                Pin = (int)userData[index, 3]
            };

            if (!user.ValidatePin(inputPin))
            {
                Console.WriteLine("Invalid PIN");
                return;
            }

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("1. Deposit  2. Withdraw: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                user.Deposit(amount, bank);
            }
            else if (choice == 2)
            {
                user.Withdraw(amount, bank);
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            //update balance back to Manager storage
            userData[index, 1] = user.Balance;
        }

        public void CheckUserBalance()
        {
            Console.Write("Enter Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            int index = FindUserIndex(accNo);
            if (index == -1)
            {
                Console.WriteLine("User not found");
                return;
            }

            Console.Write("Enter PIN: ");
            int inputPin = int.Parse(Console.ReadLine());

            User user = new User
            {
                AccountNumber = (int)userData[index, 0],
                Balance = (double)userData[index, 1],
                Pin = (int)userData[index, 3]
            };

            if (!user.ValidatePin(inputPin))
            {
                Console.WriteLine("Invalid PIN");
                return;
            }

            user.CheckBalance();
        }

    }
}
