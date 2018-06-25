using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class PurchasedPageViewModel
    {
        private ObservableCollection<PurchasedVideo> purchasedVideos = new ObservableCollection<PurchasedVideo>();
        public ObservableCollection<PurchasedVideo> PurchasedVideos { get { return this.purchasedVideos; } }

        public PurchasedPageViewModel()
        {
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Game of Thrones",
                PurchasedVideoSubTitle = "",
                ImageSource = "../Assets/boxart/tv-shows/game-of-thrones.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Blade Runner 2049",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/blade-runner-2049.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "War for the Planet of the Apes",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/war-for-the-planet-of-the-apes.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Jigsaw",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/jigsaw.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Naruto Shippuden Uncut",
                PurchasedVideoSubTitle = "",
                ImageSource = "../Assets/boxart/tv-shows/naruto-shippuden-uncut.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Star Wars: The Last Jedi",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/star-wars-the-last-jedi.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Rick and Morty",
                PurchasedVideoSubTitle = "",
                ImageSource = "../Assets/boxart/tv-shows/rick-and-morty.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Hellraiser: Judgement",
                PurchasedVideoSubTitle = "2018",
                ImageSource = "../Assets/boxart/movies/hellraiser-judgment.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Demon House",
                PurchasedVideoSubTitle = "2018",
                ImageSource = "../Assets/boxart/movies/demon-house.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "The Walking Dead",
                PurchasedVideoSubTitle = "",
                ImageSource = "../Assets/boxart/tv-shows/the-walking-dead.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "It",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/it.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Dark Tower",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/the-dark-tower.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "Baby Driver",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/baby-driver.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "The Big Bang Theory",
                PurchasedVideoSubTitle = "",
                ImageSource = "../Assets/boxart/tv-shows/big-bang-theory.png"
            });
            this.purchasedVideos.Add(new PurchasedVideo()
            {
                PurchasedVideoTitle = "My Friend Dahmer",
                PurchasedVideoSubTitle = "2017",
                ImageSource = "../Assets/boxart/movies/my-friend-dahmer.png"
            });
        }
    }
}
