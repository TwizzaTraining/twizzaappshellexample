namespace TwizzaAppShellExample.Pages;

public partial class BotPage : ContentPage
{
	public BotPage()
	{
		InitializeComponent();
	}

    private async void BotButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("dotnetbotpage");
    }
}