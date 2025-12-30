using System;

namespace BridgeLabz_Scenario
{
    internal class LibraryManagement
    {
        private static string adminPassword = "Babushka"; 

        static void Main(string[] args)
        {
            userType();
        }

        static void userType()
        {
            string[,] books = InputArray();

            string input = Console.ReadLine();
            if (input == "Admin")
            {
                string passKey = Console.ReadLine();
                if (PasswordCheck(passKey))
                {
                    AdminDisplay(books);
                }
                else
                {
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

        static bool PasswordCheck(string passKey)
        {
            return passKey.Equals(adminPassword);
        }

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
                    return i;
                }
            }
            return -1;
        }

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

        static void DisplayAllBooks(string[,] books)
        {
            for (int i = 0; i < books.GetLength(0); i++)
            {
                Console.WriteLine("Title: " + books[i, 0] + " Author: " + books[i, 1] + " Status: " + books[i, 2]);
            }
        }

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

        static void AddBook(string[,] books)
        {
            Console.WriteLine("Library size is fixed. Cannot add new rows.");
        }

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
