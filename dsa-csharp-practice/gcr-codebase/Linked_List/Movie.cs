using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
2. Doubly Linked List: Movie Management System
Problem Statement: Implement a movie management system using a doubly linked list. Each node will represent a movie and contain Movie Title, Director, Year of Release, and Rating. Implement the following functionalities:
    Add a movie record at the beginning, end, or at a specific position.
    Remove a movie record by Movie Title.
    Search for a movie record by Director or Rating.
    Display all movie records in both forward and reverse order.
    Update a movie's Rating based on the Movie Title.
*/

namespace Assignment.Linked_List
{
    class MovieNode
    {
        public string Title;
        public string Director;
        public string Year;
        public double Rating;
        public MovieNode Next;
        public MovieNode Prev;

        public MovieNode(string title, string director, string year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = Prev = null;
        }
    }
    class MovieDLL
    {
        private MovieNode head;
        private MovieNode tail;

        //Add at beginning
        public void AddAtBeginning(string title, string director, string year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.Next = head;
            newNode.Prev = null;
            head = newNode;
        }

        //Add at end
        public void AddAtEnd(string title, string director, string year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            if(head == null)
            {
                head  = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        //Add at specific position
        public void AddAtSpecificPosition(int position, string title, string director, string year, double rating)
        {
            if(position == 1)
            {
                AddAtBeginning(title, director, year, rating);
            }

            MovieNode temp = head;

            for(int i=0; i<(position-1) && temp!= null; i++)
            {
                temp = temp.Next;
            }

            if(temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            MovieNode newNode = new MovieNode(title, director, year, rating);

            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if(temp.Next != null)
            {
                temp.Next.Prev = newNode;
            }
            else
            {
                tail = newNode;
            }
            temp.Next = newNode;
        }

        //Remove by title
        public void RemoveByTitle(string title)
        {
            MovieNode temp = head;

            while(temp != null &&  temp.Title != title)
            {
                temp = temp.Next;
            }

            if( temp == null)
            {
                Console.WriteLine("Movie not found");
                return;
            }

            if(temp == head)
            {
                head = temp.Next;
            }

            if(temp == tail)
            {
                tail = temp.Prev;
            }

            if(temp.Prev != null)
            {
                temp.Prev.Next = temp;
            }

            if(temp.Next != null)
            {
                temp.Next.Prev = temp;
            }
            Console.WriteLine("Movie removed successfully");
        }

        //Search by director
        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            bool found = false;

            while(temp != null)
            {
                if(temp.Director == director)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
            {
                Console.WriteLine("Movie does not exist");
            }
        }

        //Search by Rating
        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            bool found = false;

            while(temp != null)
            {
                if(temp.Rating == rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.Next;
            }
            if (!found)
            {
                Console.WriteLine("Movie not found");
            }
        }

        //Update movie 
        public void UpdateMovie(string title, double newRating)
        {
            MovieNode temp = head;
            while(temp != null)
            {
                if(temp.Title == title)
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated Succesfully");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Movie does not exist");
        }

        //Display Forward
        public void DisplayForward()
        {
            MovieNode temp = head;
            if(temp == null)
            {
                Console.WriteLine("No movie record exist");
                return;
            }
            while(temp != null)
            {
                DisplayMovie (temp);
                temp = temp.Next;
            }
        }

        //Display reverse
        public void DisplayReverse()
        {
            MovieNode temp = tail;
            while(temp == null)
            {
                Console.WriteLine("No movie record exist");
                return;
            }
            while( temp != null)
            {
                DisplayMovie(temp);
                temp = temp.Prev;
            }
        }

        //Display Movie
        public void DisplayMovie(MovieNode movie)
        {
            Console.WriteLine($"Title : {movie.Title}, Director : {movie.Director}, Year: {movie.Year}, Rating: {movie.Rating} ");
        }
    }
    class Movie
    {
        static void Main()
        {
            MovieDLL movies = new MovieDLL();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nMovie Management System");
                Console.WriteLine("1. Add Movie at Beginning");
                Console.WriteLine("2. Add Movie at End");
                Console.WriteLine("3. Add Movie at Specific Position");
                Console.WriteLine("4. Remove Movie by Title");
                Console.WriteLine("5. Search Movie by Director");
                Console.WriteLine("6. Search Movie by Rating");
                Console.WriteLine("7. Update Movie Rating");
                Console.WriteLine("8. Display Movies Forward");
                Console.WriteLine("9. Display Movies Reverse");
                Console.WriteLine("10. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Title: ");
                        string t1 = Console.ReadLine();

                        Console.Write("Enter Director: ");
                        string d1 = Console.ReadLine();

                        Console.Write("Enter Year: ");
                        string y1 = Console.ReadLine();

                        Console.Write("Enter Rating: ");
                        double r1 = double.Parse(Console.ReadLine());

                        movies.AddAtBeginning(t1, d1, y1, r1);
                        Console.WriteLine("Movie added at beginning");
                        break;

                    case 2:
                        Console.Write("Enter Title: ");
                        string t2 = Console.ReadLine();

                        Console.Write("Enter Director: ");
                        string d2 = Console.ReadLine();

                        Console.Write("Enter Year: ");
                        string y2 = Console.ReadLine();

                        Console.Write("Enter Rating: ");
                        double r2 = double.Parse(Console.ReadLine());

                        movies.AddAtEnd(t2, d2, y2, r2);
                        Console.WriteLine("Movie added at end");
                        break;

                    case 3:
                        Console.Write("Enter Position: ");
                        int pos = int.Parse(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string t3 = Console.ReadLine();

                        Console.Write("Enter Director: ");
                        string d3 = Console.ReadLine();

                        Console.Write("Enter Year: ");
                        string y3 = Console.ReadLine();

                        Console.Write("Enter Rating: ");
                        double r3 = double.Parse(Console.ReadLine());

                        movies.AddAtSpecificPosition(pos, t3, d3, y3, r3);
                        Console.WriteLine("Movie added at position " + pos);
                        break;

                    case 4:
                        Console.Write("Enter Movie Title to remove: ");
                        string delTitle = Console.ReadLine();
                        movies.RemoveByTitle(delTitle);
                        break;

                    case 5:
                        Console.Write("Enter Director name: ");
                        string sd = Console.ReadLine();
                        movies.SearchByDirector(sd);
                        break;

                    case 6:
                        Console.Write("Enter Rating: ");
                        double sr = double.Parse(Console.ReadLine());
                        movies.SearchByRating(sr);
                        break;

                    case 7:
                        Console.Write("Enter Movie Title: ");
                        string ut = Console.ReadLine();

                        Console.Write("Enter New Rating: ");
                        double nr = double.Parse(Console.ReadLine());

                        movies.UpdateMovie(ut, nr);
                        break;

                    case 8:
                        movies.DisplayForward();
                        break;

                    case 9:
                        movies.DisplayReverse();
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
