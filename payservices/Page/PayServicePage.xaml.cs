using System;
using System.Collections.Generic;
using payservices.ViewModels;
using Xamarin.Forms;

namespace payservices.Page
{
    public partial class PayServicePage : ContentPage
    {
        public PayServicePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new PayServicePageViewModel();
        }
    }
}
