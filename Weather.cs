using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Weather
    {

        public string theWeather = "Sunny";

        public Weather()
        {

        }

        public void TrueWeather()
        {

            Random random = new Random();
            List<string> weatherforecast = new List<string> { "sunny", "cloudy"};
            int i = random.Next(weatherforecast.Count);
            Console.WriteLine(weatherforecast[i]);


        }
    }
}
  
