using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTime
{
    abstract class Movie
    {
        private string showTimes;
        private string title;

        public Movie(string showTimes, string title)
        {
            this.showTimes = showTimes;
            this.title = title;
        }

        public string GetShowTimes()
        {
            return showTimes;
        }

        public string GetTitle()
        {
            return title;
        }

        public override string ToString()
        {
            return $"Title: {title} ShowTimes: {showTimes}";
        }
    }
}


//namespace CinemaTime
//{
//    internal class Movie
//    {
//        public string Title { get; set; }
//        public string ShowTime { get; set; }

//        public Movie(string title, string showTime)
//        {
//            Title = title;
//            ShowTime = showTime;
//        }

//        public override string ToString()
//        {
//            return $"Title: {Title} | Show Time: {ShowTime}";
//        }
//    }
//}
