namespace LocationAndWeather.Dto
{
    public class Location
    {
        public string Full { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Country_ISO3166 { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Elevation { get; set; }
    }
}