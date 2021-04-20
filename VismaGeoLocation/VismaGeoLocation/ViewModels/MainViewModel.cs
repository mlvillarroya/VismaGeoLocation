using System;
using System.Collections.Generic;
using System.Text;
using VismaGeoLocation.Models;
using VismaGeoLocation.Services;

namespace VismaGeoLocation.ViewModels
{
    class MainViewModel : BaseViewModel
    {

        private OpenLocationRoot myAdress;
        public OpenLocationRoot MyAdress
        {
            get { return myAdress; }
            set
            {
                myAdress = value;
                OnPropertyChanged();
            }
        }

        private Xamarin.Essentials.Location currentLocation;
        public Xamarin.Essentials.Location CurrentLocation
        {
            get { return currentLocation; }
            set
            {
                currentLocation = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            LocateNow();
        }
        private async void LocateNow()
        {
            CurrentLocation = await GetLocation.LocateMobile();
            var OpenStreetMapAPI = new OpenStreetMapAPI();
            MyAdress = await OpenStreetMapAPI.GetCurrentAdressAsync(CurrentLocation);
        }

    }
}
