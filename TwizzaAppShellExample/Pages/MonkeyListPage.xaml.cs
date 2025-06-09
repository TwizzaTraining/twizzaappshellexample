using TwizzaAppShellExample.Interfaces;
using TwizzaAppShellExample.Models;

namespace TwizzaAppShellExample.Pages;

public partial class MonkeyListPage : ContentPage
{
    private List<Monkey> _monkeys;
    private IMonkeyService _monkeyService;

    public MonkeyListPage(IMonkeyService monkeyService)
	{
		InitializeComponent();

        _monkeyService = monkeyService;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        MonkeyListView.ItemsSource = await _monkeyService.GetMonkeys();
    }

    private async void MonkeyCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Monkey monkey = (Monkey)e.CurrentSelection;

        var navigationParameter = new ShellNavigationQueryParameters
    {
        { "Monkey", monkey }
    };

        await Shell.Current.GoToAsync("monkeypage", navigationParameter);
    }

    private async void MonkeyListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Monkey monkey = (Monkey)e.Item;

        var navigationParameter = new ShellNavigationQueryParameters
    {
        { "Monkey", monkey }
    };

        await Shell.Current.GoToAsync("monkeypage", navigationParameter);
    }
}