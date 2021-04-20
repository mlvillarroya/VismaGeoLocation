using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace VismaGeoLocation.Services
{
    class GetLocation
    {
        public static async Task<Location> LocateMobile()
        {
            CancellationTokenSource cts;

            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    return location;
                }

                else
                {
                    try
                    {
                        var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                        cts = new CancellationTokenSource();
                        location = await Geolocation.GetLocationAsync(request, cts.Token);

                        if (location != null)
                        {
                            return location;
                        }
                        else return null;
                    }
                    catch (Exception)
                    {
                        throw;
                        // Handle not supported on device exception
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
