using MarksMoviesAndTV.Classes;
using MarksMoviesAndTV.Controls;
using MarksMoviesAndTV.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MarksMoviesAndTV
{
    public sealed partial class ExplorePage : Page
    {
        public ExplorePage()
        {
            this.InitializeComponent();
            this.ViewModel = new ExplorePageViewModel();
        }

        public ExplorePageViewModel ViewModel { get; set; }

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

        private void LaunchMicrosoftStore(object sender, RoutedEventArgs e)
        {
            LaunchMicrosoftStoreTask();
        }

        private async Task LaunchMicrosoftStoreTask()
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://navigatetopage/?Id=Video"));
        }

        private void ShowAllButtonTrailers_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExplorePageL2_TrailersPage));
        }

        private void ShowAllButton360Videos_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ExplorePageL2_360VideosPage));
        }
    }
}
