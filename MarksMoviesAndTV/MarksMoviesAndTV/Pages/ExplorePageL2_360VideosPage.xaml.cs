using MarksMoviesAndTV.Controls;
using MarksMoviesAndTV.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MarksMoviesAndTV
{
    public sealed partial class ExplorePageL2_360VideosPage : Page
    {
        public ExplorePageL2_360VideosPage()
        {
            this.InitializeComponent();
            this.ViewModel = new ExplorePageL2_360VideosPageViewModel();
        }

        public ExplorePageL2_360VideosPageViewModel ViewModel { get; set; }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Window.Current.SetTitleBar(AppTitleBar);
            BackButton.Visibility = this.Frame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;

            TopNavControl topNavControl = this.FindName("TopNavControl") as TopNavControl;
            topNavControl.SetSelectedTab("ExploreTab");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            On_BackRequested();
        }

        private bool On_BackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
                return true;
            }
            return false;
        }
    }
}
