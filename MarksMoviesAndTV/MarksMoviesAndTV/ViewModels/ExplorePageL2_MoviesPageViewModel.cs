using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class ExplorePageL2_MoviesPageViewModel
    {
        private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> Movies { get { return this.movies; } }

        public ExplorePageL2_MoviesPageViewModel()
        {
            this.movies.Add(new Movie()
            {
                MovieTitle = "I, Tonya",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/i-tonya.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Demon House",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/demon-house.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Murder on the Orient Express",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies//murder-on-the-orient-express.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "I Kill Giants",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/i-kill-giants.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Disaster Artist",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-disaster-artist.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Three Billboards Outside Ebbing, Missouri",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/three-billboards.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Only the Brave",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/only-the-brave.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Kingsmen: The Golden Circle",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/kingsman-the-golden-circle.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "It",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/it.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Braven",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/braven.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Blade Runner 2049",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/blade-runner-2049.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Hitman's Bodyguard",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-hitmans-bodyguard.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Wonder",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/wonder.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Darkest Hour",
                MovieSubTitle = "$4.99",
                ImageSource = "../Assets/boxart/movies/darkest-hour.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Dark Tower",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-dark-tower.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Baby Driver",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/baby-driver.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Lady Bird",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/lady-bird.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "American Made",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/american-made.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "My Friend Dahmer",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/my-friend-dahmer.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Geostorm",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/geostorm.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Dunkirk",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/dunkirk.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "A Bad Moms Christmas",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/a-bad-moms-christmas.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "War for the Planet of the Apes",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/war-for-the-planet-of-the-apes.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Jigsaw",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/jigsaw.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Dirt (2017)",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/dirt-2017.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Happy Death Day",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/happy-death-day.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Tyler Perry's Boo 2! A Madea Halloween",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/boo-2.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Thor: Ragnarok",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/thor.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Jumanji: Welcome To The Jungle",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/jumanji.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Coco (2017)",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/coco.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Justice League",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/justice-league.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Daddy's Home 2",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/daddys-home-2.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Star Wars: The Last Jedi",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/star-wars-the-last-jedi.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Downsizing",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/downsizing.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Hellraiser: Judgement",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/hellraiser-judgment.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Bomb City",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/bomb-city.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Pitch Perfect 3",
                MovieSubTitle = "from $5.99",
                ImageSource = "../Assets/boxart/movies/pitch-perfect-3.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Man Who Invented Christmas",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-man-who-invented-christmas.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Accident Man",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/accident-man.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Still/Born",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/still-born.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Star",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-star.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Kill Order",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/kill-order.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Victor Crowley",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/victor-crowley.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Tragedy Girls",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/tragedy-girls.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Redeemed and the Dominant",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/the-redeemed-and-the-dominant.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Scorched Earth",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/scorched-earth.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Keep Watching",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/keep-watching.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Greatest Showman",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-greatest-showman.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Revenge of Robert the Doll",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/revenge-of-robert-the-doll.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Dear Dictator",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/dear-dictator.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Immortal Demon Slayer",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/immortal-demon-slayer.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "LBJ",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/LBJ.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Tilt",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/tilt.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Con Man",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/con-man.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Insidious: The Last Key",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/insidious.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Father Figures",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/father-figures.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Square",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/the-square.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Female Brain",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/the-female-brain.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Honor Up",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/honor-up.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Rape of Rect Taylor",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-rape-of-recy-taylor.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Lodgers",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/the-lodgers.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Survivors Guide to Prison",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/survivors-guide-to-prison.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "A Thousand Junkies",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/a-thousand-junkies.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Suicide Squad: Hell To Pay",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/suicide-squad-hell-to-pay.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "Prodigy",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/prodigy.png"
            });
            this.movies.Add(new Movie()
            {
                MovieTitle = "The Lullaby",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/the-lullaby.png"
            });
            
        }
    }
}
