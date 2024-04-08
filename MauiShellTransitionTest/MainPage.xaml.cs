using MauiShellTransitionTest.Pages;

namespace MauiShellTransitionTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOpenPageButtonClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ModalPage));
        }
    }

}
