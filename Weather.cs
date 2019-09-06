using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Weather
    {
        int temp;
        string forecast;
        string sunshine;
        
        public Weather()
        {

        }

        public void TrueWeather()
        {

            Random random = new Random();
            List<string> weatherForecast = new List<string> { "Sunny", "Cloudy", };
            int index = random.Next(weatherForecast.Count);
            var realForecast = weatherForecast[index];
        }

    }
}
