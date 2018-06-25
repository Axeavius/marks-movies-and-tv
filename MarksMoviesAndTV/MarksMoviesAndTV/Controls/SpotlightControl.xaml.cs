using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;

namespace MarksMoviesAndTV.Controls
{
    public sealed partial class SpotlightControl : UserControl
    {
        public SpotlightControl()
        {
            this.InitializeComponent();

            // Auto scroll every 8 seconds
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(8);
            timer.Tick += (o, a) =>
            {
                if (SpotlightFlipView.SelectedIndex >= 5)
                {
                    SpotlightFlipView.SelectedIndex = 0;
                }
                SpotlightFlipView.SelectedIndex++;
            };

            // Fix for wrapping content
            DispatcherTimer fixTimer = new DispatcherTimer();
            fixTimer.Interval = TimeSpan.FromSeconds(.1);
            fixTimer.Tick += (o, a) =>
            {
                if (SpotlightFlipView.SelectedIndex == 0)
                {
                    SpotlightFlipView.SelectedIndex = 5;
                }
                else if (SpotlightFlipView.SelectedIndex == 6)
                {
                    SpotlightFlipView.SelectedIndex = 1;
                }
            };

            timer.Start();
            fixTimer.Start();
        }

        private void LaunchMicrosoftStore(object sender, TappedRoutedEventArgs e)
        {
            LaunchMicrosoftStoreTask();
        }

        private async Task LaunchMicrosoftStoreTask()
        {
            await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://navigatetopage/?Id=Video"));
        }
    }
}
