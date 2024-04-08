using System.Reflection.PortableExecutable;

namespace MauiShellTransitionTest.Pages;

public partial class ModalPage : ContentPage
{
    public ModalPage()
	{
		InitializeComponent();
    }

    private async void OpenModelessPageButton_Clicked(object sender, EventArgs e)
    {
        var route = $"{nameof(ModelessPage)}?{nameof(ModelessPage.PageNo)}=1";
        await Shell.Current.GoToAsync(route);
    }

    private async void GoBackButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}