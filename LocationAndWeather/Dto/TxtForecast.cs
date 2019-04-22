namespace LocationAndWeather.Dto
{
    public class TxtForecast
    {
        public string Date { get; set; }

        public Forecastday[] Forecastday { get; set; }
    }
}