﻿namespace TwizzaAppShellExample.Pages
{
    public partial class DotnetBotDemoPage : ContentPage
    {
        int count = 0;


        public DotnetBotDemoPage()
        {
            InitializeComponent();
          
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
