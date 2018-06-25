using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class ExplorePageViewModel
    {
        private ObservableCollection<Movie> trailers = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> Trailers { get { return this.trailers; } }

        private ObservableCollection<Movie> videos360 = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> Videos360 { get { return this.videos360; } }

        private ObservableCollection<Movie> newMovies = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> NewMovies { get { return this.newMovies; } }

        private ObservableCollection<TVShow> newTVShows = new ObservableCollection<TVShow>();
        public ObservableCollection<TVShow> NewTVShows { get { return this.newTVShows; } }

        private ObservableCollection<Movie> salesAndSpecials = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> SalesAndSpecials { get { return this.salesAndSpecials; } }

        private ObservableCollection<Movie> featuredCollections = new ObservableCollection<Movie>();
        public ObservableCollection<Movie> FeaturedCollections { get { return this.featuredCollections; } }

        public ExplorePageViewModel()
        {
            #region Trailers
            // Trailers
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
            #endregion Trailers

            #region 360 Videos
            // 360 Videos
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
            #endregion 360 Videos

            #region NewMovies
            // New Movies
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "I, Tonya",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/i-tonya.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Demon House",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/demon-house.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Murder on the Orient Express",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies//murder-on-the-orient-express.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "I Kill Giants",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/i-kill-giants.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "The Disaster Artist",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-disaster-artist.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Three Billboards Outside Ebbing, Missouri",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/three-billboards.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Only the Brave",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/only-the-brave.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Kingsmen: The Golden Circle",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/kingsman-the-golden-circle.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "It",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/it.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Braven",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/braven.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Blade Runner 2049",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/blade-runner-2049.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "The Hitman's Bodyguard",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-hitmans-bodyguard.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Wonder",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/wonder.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Darkest Hour",
                MovieSubTitle = "$4.99",
                ImageSource = "../Assets/boxart/movies/darkest-hour.png"
            });
            this.newMovies.Add(new Movie()
            {
                MovieTitle = "Dark Tower",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/the-dark-tower.png"
            });
            #endregion NewMovies

            #region NewTVShows
            // New TV Shows
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Dragon Ball Super",
                TVShowSubTitle = "",
                NumberOfSeasons = "4 seasons",
                ImageSource = "../Assets/boxart/tv-shows/dragon-ball-super.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "The Walking Dead",
                TVShowSubTitle = "",
                NumberOfSeasons = "8 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-walking-dead.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Rick and Morty",
                TVShowSubTitle = "",
                NumberOfSeasons = "3 seasons",
                ImageSource = "../Assets/boxart/tv-shows/rick-and-morty.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Game of Thrones",
                TVShowSubTitle = "",
                NumberOfSeasons = "7 seasons",
                ImageSource = "../Assets/boxart/tv-shows/game-of-thrones.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Krypton",
                TVShowSubTitle = "",
                NumberOfSeasons = "1 season",
                ImageSource = "../Assets/boxart/tv-shows/krypton.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "RuPaul's Drag Race",
                TVShowSubTitle = "",
                NumberOfSeasons = "9 seasons",
                ImageSource = "../Assets/boxart/tv-shows/rupaul-drag-race.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Naruto Shippuden Uncut",
                TVShowSubTitle = "",
                NumberOfSeasons = "8 seasons",
                ImageSource = "../Assets/boxart/tv-shows/naruto-shippuden-uncut.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "The Big Bang Theory",
                TVShowSubTitle = "",
                NumberOfSeasons = "11 seasons",
                ImageSource = "../Assets/boxart/tv-shows/big-bang-theory.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "The Flash (2014)",
                TVShowSubTitle = "",
                NumberOfSeasons = "4 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-flash-2014.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Supernatural",
                TVShowSubTitle = "",
                NumberOfSeasons = "13 seasons",
                ImageSource = "../Assets/boxart/tv-shows/supernatural.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "South Park",
                TVShowSubTitle = "",
                NumberOfSeasons = "21 seasons",
                ImageSource = "../Assets/boxart/tv-shows/south-park.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Vikings",
                TVShowSubTitle = "",
                NumberOfSeasons = "5 seasons",
                ImageSource = "../Assets/boxart/tv-shows/vikings.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Shameless",
                TVShowSubTitle = "",
                NumberOfSeasons = "8 seasons",
                ImageSource = "../Assets/boxart/tv-shows/shameless.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Ghost Adventures",
                TVShowSubTitle = "",
                NumberOfSeasons = "18 seasons",
                ImageSource = "../Assets/boxart/tv-shows/ghost-adventures.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Atlanta",
                TVShowSubTitle = "",
                NumberOfSeasons = "2 seasons",
                ImageSource = "../Assets/boxart/tv-shows/atlanta.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "The Magicians",
                TVShowSubTitle = "",
                NumberOfSeasons = "3 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-magicians.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "The Simpsons",
                TVShowSubTitle = "",
                NumberOfSeasons = "29 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-simpsons.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Arrow",
                TVShowSubTitle = "",
                NumberOfSeasons = "6 seasons",
                ImageSource = "../Assets/boxart/tv-shows/arrow.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Riverdale",
                TVShowSubTitle = "",
                NumberOfSeasons = "2 seasons",
                ImageSource = "../Assets/boxart/tv-shows/riverdale.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "American Dad",
                TVShowSubTitle = "",
                NumberOfSeasons = "13 seasons",
                ImageSource = "../Assets/boxart/tv-shows/american-dad.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Impractical Jokers",
                TVShowSubTitle = "",
                NumberOfSeasons = "12 seasons",
                ImageSource = "../Assets/boxart/tv-shows/impractical-jokers.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Forged in Fire",
                TVShowSubTitle = "",
                NumberOfSeasons = "5 seasons",
                ImageSource = "../Assets/boxart/tv-shows/forged-in-fire.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Marvel's Agents of S.H.I.E.L.D.",
                TVShowSubTitle = "",
                NumberOfSeasons = "5 seasons",
                ImageSource = "../Assets/boxart/tv-shows/agents-of-shield.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "PAW Patrol",
                TVShowSubTitle = "",
                NumberOfSeasons = "9 seasons",
                ImageSource = "../Assets/boxart/tv-shows/paw-patrol.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "SpongeBob SquarePants",
                TVShowSubTitle = "",
                NumberOfSeasons = "11 seasons",
                ImageSource = "../Assets/boxart/tv-shows/spongebob-squarepants-11.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Gotham",
                TVShowSubTitle = "",
                NumberOfSeasons = "4 seasons",
                ImageSource = "../Assets/boxart/tv-shows/gotham.png"
            });
            this.newTVShows.Add(new TVShow()
            {
                TVShowTitle = "Rick and Morty [Boxed Set]",
                TVShowSubTitle = "",
                NumberOfSeasons = "1 season",
                ImageSource = "../Assets/boxart/tv-shows/rick-and-morty-box-set.png"
            });
            #endregion NewTVShows

            #region SalesAndSpecials
            // Sales & Specials
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Baby Driver",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/baby-driver.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Lady Bird",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/lady-bird.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "American Made",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/american-made.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "My Friend Dahmer",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/my-friend-dahmer.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Geostorm",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/geostorm.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Dunkirk",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/dunkirk.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "A Bad Moms Christmas",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/a-bad-moms-christmas.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "War for the Planet of the Apes",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/war-for-the-planet-of-the-apes.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Jigsaw",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/jigsaw.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Dirt (2017)",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/dirt-2017.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Happy Death Day",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/happy-death-day.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Tyler Perry's Boo 2! A Madea Halloween",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/boo-2.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Thor: Ragnarok",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/thor.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Jumanji: Welcome To The Jungle",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/jumanji.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Coco (2017)",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/coco.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Justice League",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/justice-league.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Daddy's Home 2",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/daddys-home-2.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Star Wars: The Last Jedi",
                MovieSubTitle = "from $6.99",
                ImageSource = "../Assets/boxart/movies/star-wars-the-last-jedi.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Downsizing",
                MovieSubTitle = "from $4.99",
                ImageSource = "../Assets/boxart/movies/downsizing.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Hellraiser: Judgement",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/hellraiser-judgment.png"
            });
            this.salesAndSpecials.Add(new Movie()
            {
                MovieTitle = "Bomb City",
                MovieSubTitle = "from $3.99",
                ImageSource = "../Assets/boxart/movies/bomb-city.png"
            });
            #endregion SalesAndSpecials

            #region FeaturedCollections
            // Featured Collections
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Thor: Ragnarok",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/thor.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Jumanji: Welcome To The Jungle",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/jumanji.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Coco (2017)",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/coco.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Justice League",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/justice-league.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Daddy's Home 2",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/daddys-home-2.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Murder on the Orient Express",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers//murder-on-the-orient-express.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Star Wars: The Last Jedi",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/star-wars-the-last-jedi.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "Downsizing",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/downsizing.png"
            });
            this.featuredCollections.Add(new Movie()
            {
                MovieTitle = "I, Tonya",
                MovieSubTitle = "",
                ImageSource = "../Assets/boxart/trailers/i-tonya.png"
            });
            #endregion FeaturedCollections
        }
    }
}
