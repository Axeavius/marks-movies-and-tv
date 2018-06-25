using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class PersonalPageViewModel
    {
        private ObservableCollection<PersonalVideo> personalVideos = new ObservableCollection<PersonalVideo>();
        public ObservableCollection<PersonalVideo> PersonalVideos { get { return this.personalVideos; } }

        public PersonalPageViewModel()
        {
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Boards of Canada - The Campfire Headphase (Full Album)",
                PersonalVideoSubTitle = "10/12/2015",
                ImageSource = "../Assets/boxart/personal/boc_campfire-headphase.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Boards of Canada - Tomorrow's Harvest (2013)",
                PersonalVideoSubTitle = "6/52013",
                ImageSource = "../Assets/boxart/personal/boc_tomorrows-harvest.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Boards of Canada - Music Has the Right to Children",
                PersonalVideoSubTitle = "4/20/1998",
                ImageSource = "../Assets/boxart/personal/boc_music-has-the-right-to-children.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Aphex Twin - Selected Soundcloud Works (2015)",
                PersonalVideoSubTitle = "1/29/2015",
                ImageSource = "../Assets/boxart/personal/afx_saw-2015.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Aphex Twin - Selected Ambient Works 85-92",
                PersonalVideoSubTitle = "2/12/1992",
                ImageSource = "../Assets/boxart/personal/afx_saw-85-92.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Shobaleader One performing \"Squarepusher Theme\"",
                PersonalVideoSubTitle = "4/7/2016",
                ImageSource = "../Assets/boxart/personal/shobaleader_performing-squarepusher-theme.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Shobaleader One - Boiler Room In Stereo",
                PersonalVideoSubTitle = "3/23/2017",
                ImageSource = "../Assets/boxart/personal/shobaleader_boiler-plate.png"
            });
            this.personalVideos.Add(new PersonalVideo()
            {
                PersonalVideoTitle = "Aphex Twin - Ventolin",
                PersonalVideoSubTitle = "3/27/1995",
                ImageSource = "../Assets/boxart/personal/afx_ventolin.png"
            });
        }
    }
}
