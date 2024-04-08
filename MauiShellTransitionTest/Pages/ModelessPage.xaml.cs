namespace MauiShellTransitionTest.Pages;

[QueryProperty(nameof(PageNo), nameof(PageNo))]
public partial class ModelessPage : ContentPage
{
    public string PageNo { get; set; }

    public ModelessPage()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Header.Text = $"Page #{PageNo}";
    }

    private async void NextButton_Clicked(object sender, EventArgs e)
    {
        var route = $"{nameof(ModelessPage)}?{nameof(PageNo)}={int.Parse(PageNo) + 1}";
        await Shell.Current.GoToAsync(route);
    }

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}