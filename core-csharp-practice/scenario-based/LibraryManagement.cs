using System;
using System.ComponentModel.Design;

namespace BridgeLabz_Scenario
{
    internal class LibraryManagement
    {
        //stores admin password, kept static so that it can be shared with methods
        private static string adminPassword = "Babushka"; 

        //entry point of the Library Management System
        static void Main(string[] args)
        {
            userType();
        }

        //this method decides whether the current user is admin or normal user
        static void userType()
        {
            string[,] books = InputArray();

            //enter the admin password
            string input = Console.ReadLine();
            if (input == "Admin")
            {
                //verify admin password
                string passKey = Console.ReadLine();
                if (PasswordCheck(passKey))
                {

                    AdminDisplay(books);
                }
                else
                {
                    //if the password is incorrect, the user is automatically moved to normal user dashboard
                    Console.WriteLine("You are not Admin!");
                    UserDisplay(books);
                }
            }
            else
            {
                Console.WriteLine("Welcome :)");
                UserDisplay(books);
            }
        }

        //checks the password entered by the admin is correct or not
        static bool PasswordCheck(string passKey)
        {
            return passKey.Equals(adminPassword);
        }

        //takes input for the books
        static string[,] InputArray()
        {
            int n = int.Parse(Console.ReadLine());
            string[,] books = new string[n, 3];

            for (int i = 0; i < n; i++)
            {
                books[i, 0] = Console.ReadLine(); // title
                books[i, 1] = Console.ReadLine(); // author
                books[i, 2] = Console.ReadLine(); // status
            }
            return books;
        }

        //menu for the normal user
        static void UserDisplay(string[,] books)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Library");
                Console.WriteLine("1. Search a book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Rent a book");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UserSearch(books);
                        break;
                    case 2:
                        DisplayAllBooks(books);
                        break;
                    case 3:
                        RentBook(books);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        //menu for the admin user
        static void AdminDisplay(string[,] books)
        {
            while (true)
            {
                Console.WriteLine("Welcome Admin to the Library");
                Console.WriteLine("1. Search a book");
                Console.WriteLine("2. Display all books");
                Console.WriteLine("3. Update book status");
                Console.WriteLine("4. Add Book");
                Console.WriteLine("5. Remove Book");
                Console.WriteLine("6. Update password");
                Console.WriteLine("7. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UserSearch(books);
                        break;
                    case 2:
                        DisplayAllBooks(books);
                        break;
                    case 3:
                        UpdateBookStatus(books);
                        break;
                    case 4:
                        AddBook(books);
                        break;
                    case 5:
                        RemoveBook(books);
                        break;
                    case 6:
                        UpdatePassword();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        //searches if the book is currently availale or not
        static int SearchBook(string[,] books, string bookName)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                if (
                    books[i, 0] != null &&
                    (books[i, 0].Equals(bookName, StringComparison.OrdinalIgnoreCase) ||
                     books[i, 1].Equals(bookName, StringComparison.OrdinalIgnoreCase))
                   )
                {
                    //if the book is found the index of the book is stored inn the index variable
                    return i;
                }
            }
            //if book not found
            return -1;
        }

        //
        static void UserSearch(string[,] books)
        {
            Console.WriteLine("Enter the book: ");
            string bookName = Console.ReadLine().Trim();

            int index = SearchBook(books, bookName);

            if (index == -1)
            {
                Console.WriteLine("Book not found");
            }
            else
            {
                Console.WriteLine("Title: " + books[index, 0] + " | Status: " + books[index, 2]);
            }
        }

        //display all the books in library
        static void DisplayAllBooks(string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                Console.WriteLine("Title: " + books[i, 0] + " Author: " + books[i, 1] + " Status: " + books[i, 2]);
            }
        }


        //tells whether the book is availabe to be rented or not
        static void RentBook(string[,] books)
        {
            Console.WriteLine("Enter the book: ");
            string bookName = Console.ReadLine().Trim();

            int index = SearchBook(books, bookName);

            if (index == -1)
            {
                Console.WriteLine("Book not found");
                return;
            }

            if (books[index, 2].Equals("Available", StringComparison.OrdinalIgnoreCase))
            {
                books[index, 2] = "Checked Out";
                Console.WriteLine("Book rented successfully on " + DateTime.Now);
            }
            else
            {
                Console.WriteLine("Book is already checked out");
            }
        }

        //allows admin to update the status of the book in theh library
        static void UpdateBookStatus(string[,] books)
        {
            Console.WriteLine("Enter book name:");
            string bookName = Console.ReadLine();

            int index = SearchBook(books, bookName);

            if (index == -1)
            {
                Console.WriteLine("Book not found");
                return;
            }

            Console.WriteLine("Enter new status:");
            books[index, 2] = Console.ReadLine();
            Console.WriteLine("Status updated");
        }

        //library size fixed
        static void AddBook(string[,] books)
        {
            Console.WriteLine("Library size is fixed. Cannot add new rows.");
        }

        //remove a book from the data
        static void RemoveBook(string[,] books)
        {
            Console.WriteLine("Enter the book name to be removed: ");
            string bookName = Console.ReadLine();

            for (int i = 0; i < books.GetLength(0); i++)
            {
                if (books[i, 0] != null &&
                    books[i, 0].Equals(bookName, StringComparison.OrdinalIgnoreCase))
                {
                    books[i, 0] = null;
                    books[i, 1] = null;
                    books[i, 2] = "Removed";
                    Console.WriteLine("Book removed");
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }

        //allows the admin to change the password
        private static void UpdatePassword()
        {
            Console.Write("Enter current password: ");
            string oldPassword = Console.ReadLine();

            if (!PasswordCheck(oldPassword))
            {
                Console.WriteLine("Incorrect password");
                return;
            }

            Console.Write("Enter new password: ");
            adminPassword = Console.ReadLine();

            Console.WriteLine("Password updated successfully");
        }
    }
}
