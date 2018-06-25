using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class ExplorePageL2_360VideosPageViewModel
    {
        private ObservableCollection<Movie> videos360 = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> Videos360 { get { return this.videos360; } }

        public ExplorePageL2_360VideosPageViewModel()
        {
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Through the Masks of LUZIA Teaser - Full virtual reality experience coming soon on Cirque du Soleil VR",
                MovieSubTitle = "49 secs",
                ImageSource = "../Assets/boxart/360-videos/through-the-masks-of-luzia.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "The Batmersive VR Experience",
                MovieSubTitle = "6 mins",
                ImageSource = "../Assets/boxart/360-videos/the-batmersive-vr-experience.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Amazing China",
                MovieSubTitle = "2 mins",
                ImageSource = "../Assets/boxart/360-videos/amazing-china.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "INVASION!",
                MovieSubTitle = "7 mins",
                ImageSource = "../Assets/boxart/360-videos/invasion.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "ROGUE ONE: A STAR WARS STORY IN 360",
                MovieSubTitle = "4 mins",
                ImageSource = "../Assets/boxart/360-videos/rogue-one-in-360.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: The Carnival Mask Maker",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-the-carnival-mask-maker.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro Music: \"TKO\" Bassnectar feat Zion I and Rye Rye",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-music-tko-bassnectar.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "ASTEROIDS! Sneak Peak",
                MovieSubTitle = "5 mins",
                ImageSource = "../Assets/boxart/360-videos/asteroids-sneak-peek.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Dreams of \"O\" Teaser - Full virtual reality experience coming soon on Cirque du Soleil VR",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/dreams-of-o-teaser.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Inside the Box of Kurios Teaser - Full virtual reality experience coming soon on Cirque du Soleil VR",
                MovieSubTitle = "2 mins",
                ImageSource = "../Assets/boxart/360-videos/inside-the-box-of-kurios-teaser.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: JetPack Man",
                MovieSubTitle = "2 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-jetpackman.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: The Wimbledon Experience with the Bryan Brothers",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-wimbledon-experience.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: Danny MacAskill - Cascadia in Virtual Reality",
                MovieSubTitle = "2 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-danny-macaskill.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "IEM - Unicorns of Love vs Flash Wolves",
                MovieSubTitle = "13 mins",
                ImageSource = "../Assets/boxart/360-videos/iem-league-of-legends-1.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: Inside a V8 Supercar with Holden Racing Team",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-inside-a-v8-supercar.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: Chinese Lion Dance",
                MovieSubTitle = "2 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-chinese-lion-dance.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: Land, Air, and Sea",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-land-air-and-sea.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: Swimming with Wild Dolphins in the Ocean",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-swimming-with-wild-dolphins.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "GoPro VR: Skydiving with GoPro Bombsquad - A Virtual Reality Experience",
                MovieSubTitle = "4 mins",
                ImageSource = "../Assets/boxart/360-videos/gopro-vr-skydiving.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Capturing Everest",
                MovieSubTitle = "9 mins",
                ImageSource = "../Assets/boxart/360-videos/capturing-everest.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "I'm 8",
                MovieSubTitle = "3 mins",
                ImageSource = "../Assets/boxart/360-videos/inspirational-1.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Sizophilia",
                MovieSubTitle = "5 mins",
                ImageSource = "../Assets/boxart/360-videos/inspirational-2.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Small Innovations, Big Impact",
                MovieSubTitle = "4 mins",
                ImageSource = "../Assets/boxart/360-videos/inspirational-3.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Philanthropists in Golf Carts Eating Dilly Bars",
                MovieSubTitle = "4 mins",
                ImageSource = "../Assets/boxart/360-videos/inspirational-4.png"
            });
            this.videos360.Add(new Movie()
            {
                MovieTitle = "Melinda and Bill Gates: Backstage with President Jimmy Carter",
                MovieSubTitle = "4 mins",
                ImageSource = "../Assets/boxart/360-videos/inspirational-5.png"
            });
        }
    }
}
