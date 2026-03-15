using System.Diagnostics;

namespace MauiMainPageLoadedTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void TrackDegFRBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Debug.WriteLine($"TrackDegFRBtn_CheckedChanged: {e.Value} ");
        }

        private void TrackDegCRBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Debug.WriteLine($"TrackDegCRBtn_CheckedChanged: {e.Value} ");
        }
    }
}
