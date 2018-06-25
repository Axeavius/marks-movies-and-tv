using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MarksMoviesAndTV.Controls
{
    public sealed partial class PersonalNavControl : UserControl
    {
        public PersonalNavControl()
        {
            this.InitializeComponent();
        }

        private void VideoFoldersTab_Click(object sender, RoutedEventArgs e)
        {
            //((Frame)Window.Current.Content).Navigate(typeof(PersonalPageL2_VideoFoldersPage));
        }

        private void RemovableStorageTab_Click(object sender, RoutedEventArgs e)
        {
            //((Frame)Window.Current.Content).Navigate(typeof(PersonalPageL2_RemovableStoragePage));
        }

        private void MediaServersTab_Click(object sender, RoutedEventArgs e)
        {
            //((Frame)Window.Current.Content).Navigate(typeof(PersonalPageL2_MediaServersPage));
        }
    }
}
