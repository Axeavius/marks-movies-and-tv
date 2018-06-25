using MarksMoviesAndTV.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksMoviesAndTV.ViewModels
{
    public class ExplorePageL2_TVPageViewModel
    {
        private ObservableCollection<TVShow> tvShows = new ObservableCollection<TVShow>();
        public ObservableCollection<TVShow> TVShows { get { return this.tvShows; } }

        public ExplorePageL2_TVPageViewModel()
        {
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Dragon Ball Super",
                TVShowSubTitle = "",
                NumberOfSeasons = "4 seasons",
                ImageSource = "../Assets/boxart/tv-shows/dragon-ball-super.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "The Walking Dead",
                TVShowSubTitle = "",
                NumberOfSeasons = "8 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-walking-dead.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Rick and Morty",
                TVShowSubTitle = "",
                NumberOfSeasons = "3 seasons",
                ImageSource = "../Assets/boxart/tv-shows/rick-and-morty.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Game of Thrones",
                TVShowSubTitle = "",
                NumberOfSeasons = "7 seasons",
                ImageSource = "../Assets/boxart/tv-shows/game-of-thrones.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Krypton",
                TVShowSubTitle = "",
                NumberOfSeasons = "1 season",
                ImageSource = "../Assets/boxart/tv-shows/krypton.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "RuPaul's Drag Race",
                TVShowSubTitle = "",
                NumberOfSeasons = "9 seasons",
                ImageSource = "../Assets/boxart/tv-shows/rupaul-drag-race.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Naruto Shippuden Uncut",
                TVShowSubTitle = "",
                NumberOfSeasons = "8 seasons",
                ImageSource = "../Assets/boxart/tv-shows/naruto-shippuden-uncut.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "The Big Bang Theory",
                TVShowSubTitle = "",
                NumberOfSeasons = "11 seasons",
                ImageSource = "../Assets/boxart/tv-shows/big-bang-theory.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "The Flash (2014)",
                TVShowSubTitle = "",
                NumberOfSeasons = "4 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-flash-2014.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Supernatural",
                TVShowSubTitle = "",
                NumberOfSeasons = "13 seasons",
                ImageSource = "../Assets/boxart/tv-shows/supernatural.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "South Park",
                TVShowSubTitle = "",
                NumberOfSeasons = "21 seasons",
                ImageSource = "../Assets/boxart/tv-shows/south-park.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Vikings",
                TVShowSubTitle = "",
                NumberOfSeasons = "5 seasons",
                ImageSource = "../Assets/boxart/tv-shows/vikings.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Shameless",
                TVShowSubTitle = "",
                NumberOfSeasons = "8 seasons",
                ImageSource = "../Assets/boxart/tv-shows/shameless.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Ghost Adventures",
                TVShowSubTitle = "",
                NumberOfSeasons = "18 seasons",
                ImageSource = "../Assets/boxart/tv-shows/ghost-adventures.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Atlanta",
                TVShowSubTitle = "",
                NumberOfSeasons = "2 seasons",
                ImageSource = "../Assets/boxart/tv-shows/atlanta.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "The Magicians",
                TVShowSubTitle = "",
                NumberOfSeasons = "3 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-magicians.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "The Simpsons",
                TVShowSubTitle = "",
                NumberOfSeasons = "29 seasons",
                ImageSource = "../Assets/boxart/tv-shows/the-simpsons.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Arrow",
                TVShowSubTitle = "",
                NumberOfSeasons = "6 seasons",
                ImageSource = "../Assets/boxart/tv-shows/arrow.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Riverdale",
                TVShowSubTitle = "",
                NumberOfSeasons = "2 seasons",
                ImageSource = "../Assets/boxart/tv-shows/riverdale.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "American Dad",
                TVShowSubTitle = "",
                NumberOfSeasons = "13 seasons",
                ImageSource = "../Assets/boxart/tv-shows/american-dad.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Impractical Jokers",
                TVShowSubTitle = "",
                NumberOfSeasons = "12 seasons",
                ImageSource = "../Assets/boxart/tv-shows/impractical-jokers.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Forged in Fire",
                TVShowSubTitle = "",
                NumberOfSeasons = "5 seasons",
                ImageSource = "../Assets/boxart/tv-shows/forged-in-fire.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Marvel's Agents of S.H.I.E.L.D.",
                TVShowSubTitle = "",
                NumberOfSeasons = "5 seasons",
                ImageSource = "../Assets/boxart/tv-shows/agents-of-shield.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "PAW Patrol",
                TVShowSubTitle = "",
                NumberOfSeasons = "9 seasons",
                ImageSource = "../Assets/boxart/tv-shows/paw-patrol.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "SpongeBob SquarePants",
                TVShowSubTitle = "",
                NumberOfSeasons = "11 seasons",
                ImageSource = "../Assets/boxart/tv-shows/spongebob-squarepants-11.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Gotham",
                TVShowSubTitle = "",
                NumberOfSeasons = "4 seasons",
                ImageSource = "../Assets/boxart/tv-shows/gotham.png"
            });
            this.tvShows.Add(new TVShow()
            {
                TVShowTitle = "Rick and Morty [Boxed Set]",
                TVShowSubTitle = "",
                NumberOfSeasons = "1 season",
                ImageSource = "../Assets/boxart/tv-shows/rick-and-morty-box-set.png"
            });
        }
    }
}
