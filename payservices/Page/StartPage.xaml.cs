using System;
using System.Collections.Generic;
using payservices.ViewModels;
using Xamarin.Forms;

namespace payservices.Page
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new StartPageViewModel();
        }
    }
}
