using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Day
    {
        
       public Weather weather = new Weather();
       public Recipe recipe = new Recipe();
       public Customer customer = new Customer();
        public Day()
        {
          
        }


        public void TheDayBegins()
        {
            weather.TrueWeather(); //bring the weather


            //import the recipe
        }

        public void TheCustomersArrive()
        {
            //the customers are filtered according to the weather and recipe and money is placed into the pocket of the player
        }

        public void DayEnds()
        {
            //earnings = multiple the List.(count) * Lemonade
            //display resultshj
        }
      
        
    }
}