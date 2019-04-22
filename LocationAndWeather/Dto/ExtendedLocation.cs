namespace LocationAndWeather.Dto
{
    public class ExtendedLocation : Location
    {
        public string State_Name { get; set; }

        public string Zip { get; set; }

        public string Magic { get; set; }

        public string Wmo { get; set; }
    }
}