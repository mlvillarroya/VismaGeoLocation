using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VismaGeoLocation.Views;

namespace VismaGeoLocation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
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
