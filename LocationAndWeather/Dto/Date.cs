namespace LocationAndWeather.Dto
{
    public class Date
    {
        public string Epoch { get; set; }

        public string Pretty { get; set; }

        public byte Day { get; set; }

        public byte Month { get; set; }

        public ushort Year { get; set; }

        public ushort Yday { get; set; }

        public byte Hour { get; set; }

        public byte Min { get; set; }

        public byte Sec { get; set; }

        public string IsDst { get; set; }

        public string MonthName { get; set; }

        public string MonthName_Short { get; set; }

        public string Weekday_Short { get; set; }

        public string Weekday { get; set; }

        public string AmPm { get; set; }

        public string Tz_Short { get; set; }

        public string Tz_Long { get; set; }
    }
}