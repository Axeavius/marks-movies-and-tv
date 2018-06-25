using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MarksMoviesAndTV.Controls
{
    public sealed partial class FooterControl : UserControl
    {
        public FooterControl()
        {
            this.InitializeComponent();
        }

        private void LaunchMicrosoftStore(object sender, RoutedEventArgs e)
        {
            LaunchMicrosoftStoreTask();
        }

        private async Task LaunchMicrosoftStoreTask()
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://navigatetopage/?Id=Video"));
        }
    }
}
