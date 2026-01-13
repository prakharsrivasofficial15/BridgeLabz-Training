using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CinemaTime
{
    internal class MovieUtilityImpl : IMovieService
    {
        private string[] movieTitles;
        private string[] movieTimes;
        private int count = 0;

        public MovieUtilityImpl()
        {
            Console.Write("Enter number of movies to store: ");
            int size;

            while (true)
            {
                Console.WriteLine("Enter the number of movies to be stored: ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out size) && size > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid Input");
            }
            movieTitles = new string[size];
            movieTimes = new string[size];
        }

        public void AddMovie(string title, string showTime)
        {
            if(count >= movieTitles.Length)
            {
                Console.WriteLine("No new movie could be added");
                return;
            }
            movieTitles[count] = title;
            movieTimes[count] = showTime;
            count++;
            Console.WriteLine("Movie Added Successfully");
        }

        public void SearchMovie(string keyword)
        {
            bool found = false;

            for(int i=0;  i<movieTitles.Length; i++)
            {
                if (movieTitles[i] != null && movieTitles[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Title: {movieTitles[i]} | movieShowTimes: {movieTimes[i]}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Movie Not Found");
            }
        }

        public void DisplayAllMovies()
        {
            if(count == 0)
            {
                Console.WriteLine("No Movies in the list");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Title: {movieTitles[i]} | movieShowTimes: {movieTimes[i]}");
            }
        }
    }
}
