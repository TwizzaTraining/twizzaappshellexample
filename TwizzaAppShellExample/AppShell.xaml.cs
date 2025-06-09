using TwizzaAppShellExample.Pages;

namespace TwizzaAppShellExample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            Routing.RegisterRoute("dotnetbotpage", typeof(DotnetBotDemoPage));
            Routing.RegisterRoute("monkeypage", typeof(MonkeyPage));
        }
    }
}
