using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.Classes
{
    public class TVShow
    {
        public string TVShowTitle { get; set; }
        public string TVShowSubTitle { get; set; }
        public string NumberOfSeasons { get; set; }
        public string ImageSource { get; set; }

        public TVShow()
        {
            this.TVShowTitle = "TV Show Title";
            this.TVShowSubTitle = "from $3.99";
            this.NumberOfSeasons = "2 seasons";
            this.ImageSource = "../Assets/boxart/tv-shows/tvshow.png";
        }
    }
}
