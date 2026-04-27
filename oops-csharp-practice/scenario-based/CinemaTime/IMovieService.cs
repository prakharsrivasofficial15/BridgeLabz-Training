using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTime
{
    internal interface IMovieService
    {
        void AddMovie(string title, string time);
        void SearchMovie(string keyword);
        void DisplayAllMovies();
    }
}
