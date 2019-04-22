namespace LocationAndWeather.Dto
{
    public class Forecastday
    {
        public byte Period { get; set; }

        public string Icon { get; set; }

        public string Icon_Url { get; set; }

        public string Title { get; set; }

        public string FctText { get; set; }

        public string FctText_Metric { get; set; }

        public string Pop { get; set; }
    }
}