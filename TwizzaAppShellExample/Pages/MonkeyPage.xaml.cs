using TwizzaAppShellExample.Models;

namespace TwizzaAppShellExample.Pages;

[QueryProperty(nameof(Monkey), "Monkey")]
public partial class MonkeyPage : ContentPage
{
    private Monkey _monkey;
    public Monkey Monkey
    {
        get { return _monkey; }
        set
        {
            _monkey = value;
            OnPropertyChanged();
        }
    }

    public MonkeyPage()
	{
		InitializeComponent();

        BindingContext = this;
	}
}