﻿using Proyecto9_PM2_Grupo_2.ViewModels;


namespace Proyecto9_PM2_Grupo_2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);

           


        }
    }
}