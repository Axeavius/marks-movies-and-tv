using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MarksMoviesAndTV.Controls
{
    public sealed partial class TopNavControl : UserControl
    {
        public TopNavControl()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public void SetSelectedTab(string SelectedTab)
        {
            string selectedTab = SelectedTab;

            if (selectedTab == "ExploreTab")
            {
                ExploreTab.Style = (Style)Application.Current.Resources["TopNavHeaderButtonActiveStyle"];
            }
            else if (selectedTab == "PurchasedTab")
            {
                PurchasedTab.Style = (Style)Application.Current.Resources["TopNavHeaderButtonActiveStyle"];
            }
            else if (selectedTab == "PersonalTab")
            {
                PersonalTab.Style = (Style)Application.Current.Resources["TopNavHeaderButtonActiveStyle"];
            }
        }

        private void ExploreTab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(ExplorePage));
        }

        private void PurchasedTab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(PurchasedPage));
        }

        private void PersonalTab_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(PersonalPage));
        }

        private void LaunchMicrosoftStore(object sender, RoutedEventArgs e)
        {
            LaunchMicrosoftStoreTask();
        }

        private async Task LaunchMicrosoftStoreTask()
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://navigatetopage/?Id=Video"));
        }

        private void SettingsPage_Click(object sender, RoutedEventArgs e)
        {
            ((Frame)Window.Current.Content).Navigate(typeof(SettingsPage));
        }
    }
}
