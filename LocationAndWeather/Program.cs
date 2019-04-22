using System;
using System.Device.Location;

namespace LocationAndWeather
{
    class Program
    {
        private static GeoCoordinateWatcher geoCoordinateWatcher;
        private static WeatherInfoProvider weatherInfoProvider;

        static void Main(string[] args)
        {
            // The API_KEY need to be requested from here: http://www.wunderground.com/weather/api
            weatherInfoProvider = new WeatherInfoProvider(null);
            
            // Use the WeatherInfoProvider directly
            var weatherAndLocationInfo = weatherInfoProvider.GetInfo(47.40, 19.20);
            // TODO: use weatherAndLocationInfo

            // Use the WeatherInfoProvider indirectly after getting Location info
            geoCoordinateWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            geoCoordinateWatcher.Start();
            geoCoordinateWatcher.PositionChanged += GeoCoordinateWatcher_PositionChanged;

            Console.ReadLine();
        }

        private static void GeoCoordinateWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            geoCoordinateWatcher.Stop();
            var weatherAndLocationInfo = weatherInfoProvider.GetInfo(e.Position.Location.Latitude, e.Position.Location.Longitude);
            // TODO: use weatherAndLocationInfo
        }
    }
}
