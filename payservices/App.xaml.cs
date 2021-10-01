using System;
using payservices.Page;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace payservices
{
    public partial class App : Application
    {
        public string typeProvider { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new StartPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
