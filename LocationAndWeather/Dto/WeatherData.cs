namespace LocationAndWeather.Dto
{
    public class WeatherData
    {
        public Response Response { get; set; }

        public CurrentObservation Current_Observation { get; set; }

        public Forecast Forecast { get; set; }
    }
}
