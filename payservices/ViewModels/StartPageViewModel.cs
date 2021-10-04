using System;
using payservices.Page;
using Xamarin.Forms;

namespace payservices.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        public Command PayCommand { get;}
        public StartPageViewModel()
        {
            PayCommand = new Command(() =>
            {
                
                Application.Current.MainPage =  new NavigationPage(new PayServicePage());
            });
        }
    }
}
