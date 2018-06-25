using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MarksMoviesAndTV.Controls
{
    public sealed partial class ExploreNavControl : UserControl
    {
        public ExploreNavControl()
        {
            this.InitializeComponent();
        }

        private void TrailersTab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ExplorePageL2_TrailersPage));
        }

        private void Videos360Tab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ExplorePageL2_360VideosPage));
        }

        private void MoviesTab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ExplorePageL2_MoviesPage));
        }

        private void TVTab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ExplorePageL2_TVPage));
        }
    }
}
