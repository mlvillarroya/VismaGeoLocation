using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VismaGeoLocation.Models;
using Xamarin.Essentials;

namespace VismaGeoLocation.Services
{
    public class OpenStreetMapAPI
    {
        public async Task<OpenLocationRoot> GetCurrentAdressAsync(Location CurrentLocation)
        {
            var client = new HttpClient();
            string uri = "https://nominatim.openstreetmap.org/reverse?format=json&lat=" + CurrentLocation.Latitude + "&lon=" + CurrentLocation.Longitude + "&zoom=18&addressdetails=1";
            var response = await client.GetStringAsync(uri);
            return JsonConvert.DeserializeObject<OpenLocationRoot>(response);
        }
    }
}
