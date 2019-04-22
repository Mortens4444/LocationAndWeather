using System;

namespace LocationAndWeather.Dto
{
    public class CurrentObservation
    {
        public Image Image { get; set; }

        public ExtendedLocation Display_Location { get; set; }

        public Location Observation_Location { get; set; }

        public string Station_Id { get; set; }

        public string Observation_Time { get; set; }

        public DateTimeOffset Observation_Time_RFC822 { get; set; }

        public string Observation_Epoch;

		public DateTimeOffset Local_Time_RFC822 { get; set; }

        public string Local_Epoch { get; set; }

        public string Local_Tz_Short { get; set; }

        public string Local_Tz_Long { get; set; }

        public string Local_Tz_Offset { get; set; }

        public string Weather { get; set; }

        public string Temperature_String { get; set; }

        public string Temp_F { get; set; }

        public string Temp_C { get; set; }

        public string Relative_Humidity { get; set; }

        public string Wind_String { get; set; }

        public string Wind_Dir { get; set; }

        public string Wind_Degrees { get; set; }

        public string Wind_Mph { get; set; }

        public string Wind_GustMph { get; set; }

        public string Wind_Kph { get; set; }

        public string Wind_Gust_Kph { get; set; }

        public string Pressure_Mb { get; set; }

        public string Pressure_In { get; set; }

        public string Pressure_Trend { get; set; }

        public string Dewpoint_String { get; set; }

        public string Dewpoint_F { get; set; }

        public string Dewpoint_C { get; set; }

        public string Heat_Index_String { get; set; }

        public string Heat_Index_F { get; set; }

        public string Heat_Index_C { get; set; }

        public string Windchill_String { get; set; }

        public string Windchill_F { get; set; }

        public string Windchill_C { get; set; }

        public string Feelslike_String { get; set; }

        public string Feelslike_F { get; set; }

        public string Feelslike_C { get; set; }

        public string Visibility_Mi { get; set; }

        public string Visibility_Km { get; set; }

        public string SolarRadiation { get; set; }

        public string UV { get; set; }

        public string Precip_1hr_String { get; set; }

        public string Precip_1hr_In { get; set; }

        public string Precip_1hr_Metric { get; set; }

        public string Precip_Today_String { get; set; }

        public string Precip_Today_In { get; set; }

        public string Precip_Today_Metric { get; set; }

        public string Soil_Temp_F { get; set; }

        public string Icon { get; set; }

        public string Icon_Url { get; set; }

        public string Forecast_Url { get; set; }

        public string History_Url { get; set; }

        public string Ob_Url { get; set; }

        public string Nowcast { get; set; }
    }
}