using LocationAndWeather.Dto;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net;
using System.Xml;

namespace LocationAndWeather
{
    public class WeatherInfoProvider
    {
        private const string BaseUrl = "http://api.wunderground.com/";

        private readonly string apiKey;
        private readonly CultureInfo englishCultureInfo;

        /// <summary>
        /// You can obtain your API key from here: http://www.wunderground.com/weather/api
        /// </summary>
        /// <param name="apiKey">Key for https://www.wunderground.com weather API</param>
        public WeatherInfoProvider(string apiKey)
        {
            if (String.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException("The API_KEY need to be requested from this website after registration: http://www.wunderground.com/weather/api", nameof(apiKey));
            }
            this.apiKey = apiKey;
            englishCultureInfo = new CultureInfo("en-EN");
        }

        public WeatherAndLocationInfo GetInfo(double latitude, double longitude)
        {
            var latitudeStr = latitude.ToString(englishCultureInfo);
            var longitudeStr = longitude.ToString(englishCultureInfo);

            var result = new WeatherAndLocationInfo
            {
                XmlDocument = new XmlDocument()
            };

            string xmlContent, jsonWeatherContent;
            using (var wc = new WebClient())
            {
                xmlContent = wc.DownloadString($"{BaseUrl}auto/wui/geo/GeoLookupXML/index.xml?query={latitudeStr},{longitudeStr}");
                jsonWeatherContent = wc.DownloadString($"{BaseUrl}api/{apiKey}/conditions/forecast/alert/q/{latitudeStr},{longitudeStr}.json");
                result.WeatherData = JsonConvert.DeserializeObject<WeatherData>(jsonWeatherContent);
            }
            result.XmlDocument.LoadXml(xmlContent);
            return result;
        }
    }
}
