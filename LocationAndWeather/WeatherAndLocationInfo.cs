using LocationAndWeather.Dto;
using System.Xml;

namespace LocationAndWeather
{
    public class WeatherAndLocationInfo
    {
        public XmlDocument XmlDocument { get; set; }

        public WeatherData WeatherData { get; set; }
    }
}