using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTime
{
    internal class MovieMenu
    {
        private IMovieService movieService;

        public void start()
        {
            movieService = new MovieUtilityImpl();

            while (true)
            {
                Console.WriteLine("Welcome To Movies Moderator");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Display All Movies inn the List");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your Choice");
                int choice = int.Parse(Console.ReadLine());

                while (true)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Movie Title:");
                            string title = Console.ReadLine();

                            Console.WriteLine("Enter Movie Show Times: ");
                            string showTime = Console.ReadLine();

                            movieService.AddMovie(title, showTime);
                            break;

                        case 2:
                            Console.WriteLine("Enter the Keyword: ");
                            string keyWord = Console.ReadLine();
                            movieService.SearchMovie(keyWord);
                            break;

                        case 3:
                            movieService.DisplayAllMovies();
                            break;

                        case 4:
                            Console.WriteLine("Exit");
                            return;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
            }
        }
    }
}
