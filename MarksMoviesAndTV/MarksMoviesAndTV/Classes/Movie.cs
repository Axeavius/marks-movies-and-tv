using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.Classes
{
    public class Movie
    {
        public string MovieTitle { get; set; }
        public string MovieSubTitle { get; set; }
        public string ImageSource { get; set; }

        public Movie()
        {
            this.MovieTitle = "Movie Title";
            this.MovieSubTitle = "from $3.99";
            this.ImageSource = "../Assets/boxart/trailers/movie.png";
        }
    }
}
