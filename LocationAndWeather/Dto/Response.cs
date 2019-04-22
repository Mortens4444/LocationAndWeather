namespace LocationAndWeather.Dto
{
    public class Response
    {
        public string Version { get; set; }

        public string TermsOfService { get; set; }

        public Features Features { get; set; }

        public Error Error { get; set; }
    }
}