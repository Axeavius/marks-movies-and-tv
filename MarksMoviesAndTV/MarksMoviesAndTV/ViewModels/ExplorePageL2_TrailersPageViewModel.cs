using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class ExplorePageL2_TrailersPageViewModel
    {
        private ObservableCollection<Movie> trailers = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> Trailers { get { return this.trailers; } }

        public ExplorePageL2_TrailersPageViewModel()
        {
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Thor: Ragnarok",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/thor.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Jumanji: Welcome To The Jungle",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/jumanji.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Coco (2017)",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/coco.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Justice League",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/justice-league.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Daddy's Home 2",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/daddys-home-2.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Murder on the Orient Express",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers//murder-on-the-orient-express.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Star Wars: The Last Jedi",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/star-wars-the-last-jedi.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Downsizing",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/downsizing.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "I, Tonya",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/i-tonya.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Three Billboards Outside Ebbing, Missouri",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/three-billboards.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Disaster Artist",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/disaster-artist.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Hellraiser: Judgement",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/hellraiser-judgment.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Darkest Hour",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/darkest-hour.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Wonder",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/wonder.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Dirt (2017)",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/dirt.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Bomb City",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/bomb-city.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Pitch Perfect 3",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/pitch-perfect-3.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Man Who Invented Christmas",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-man-who-invented-christmas.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "I Kill Giants",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/i-kill-giants.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Accident Man",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/accident-man.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Still/Born",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/still-born.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Star",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-star.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Kill Order",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/kill-order.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Demon House",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/demon-house.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Victor Crowley",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/victor-crowley.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Tragedy Girls",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/tragedy-girls.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Redeemed and the Dominant",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-redeemed-and-the-dominant.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Braven",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/braven.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Tyler Perry's Boo 2! A Madea Halloween",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/boo-2.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Scorched Earth",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/scorched-earth.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Keep Watching",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/keep-watching.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Greatest Showman",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-greatest-showman.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Revenge of Robert the Doll",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/revenge-of-robert-the-doll.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Dear Dictator",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/dear-dictator.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Immortal Demon Slayer",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/immortal-demon-slayer.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "LBJ",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/LBJ.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Tilt",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/tilt.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Con Man",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/con-man.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Insidious: The Last Key",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/insidious.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Father Figures",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/father-figures.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Square",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-square.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Female Brain",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-female-brain.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Honor Up",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/honor-up.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Rape of Rect Taylor",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-rape-of-recy-taylor.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Lodgers",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-lodgers.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "A Thousand Junkies",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/a-thousand-junkies.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Suicide Squad: Hell To Pay",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/suicide-squad-hell-to-pay.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Prodigy",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/prodigy.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "The Lullaby",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/the-lullaby.png"
            });
            this.trailers.Add(new Movie()
            {
                MovieTitle = "Survivors Guide to Prison",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/survivors-guide-to-prison.png"
            });
        }
    }
}
