namespace LocationAndWeather.Dto
{
    public class ExtendedForecastday
    {
        public Date Date { get; set; }

        public byte Period { get; set; }

        public Temperature High { get; set; }

        public Temperature Low { get; set; }

        public string Conditions { get; set; }

        public string Icon { get; set; }

        public string Icon_Url { get; set; }

        public string SkyIcon { get; set; }

        public string Pop { get; set; }

        public QuantitativePrecipitationForecast QPF_Allday { get; set; }

        public QuantitativePrecipitationForecast QPF_Day { get; set; }

        public QuantitativePrecipitationForecast QPF_Night { get; set; }

        public QuantitativePrecipitationForecast Snow_Allday { get; set; }

        public QuantitativePrecipitationForecast Snow_Day { get; set; }

        public QuantitativePrecipitationForecast Snow_Night { get; set; }

        public WindProperties MaxWind { get; set; }

        public WindProperties AveWind { get; set; }

        public string AveHumidity { get; set; }

        public string MaxHumidity { get; set; }

        public string MinHumidity { get; set; }
    }
}