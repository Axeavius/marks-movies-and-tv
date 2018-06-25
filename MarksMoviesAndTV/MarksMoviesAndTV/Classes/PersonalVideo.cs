using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.Classes
{
    public class PersonalVideo
    {
        public string PersonalVideoTitle { get; set; }
        public string PersonalVideoSubTitle { get; set; }
        public string ImageSource { get; set; }

        public PersonalVideo()
        {
            this.PersonalVideoTitle = "Personal Video Title";
            this.PersonalVideoSubTitle = "10/10/2020";
            this.ImageSource = "../Assets/boxart/personal-video/personal-video-title.png";
        }
    }
}
