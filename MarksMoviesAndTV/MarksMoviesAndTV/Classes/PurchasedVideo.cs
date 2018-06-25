using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.Classes
{
    public class PurchasedVideo
    {
        public string PurchasedVideoTitle { get; set; }
        public string PurchasedVideoSubTitle { get; set; }
        public string ImageSource { get; set; }

        public PurchasedVideo()
        {
            this.PurchasedVideoTitle = "Purchased Video Title";
            this.PurchasedVideoSubTitle = "2018";
            this.ImageSource = "../Assets/boxart/movies/movie-title.png";
        }
    }
}
