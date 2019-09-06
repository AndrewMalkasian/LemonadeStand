using System;
using System.Collections.Generic;

namespace LemondStandTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c = new Customer();
            
            List<CustomerTraits> thing = new List<CustomerTraits>();
            c.FilterByWeather2(thing, new Weather());




           Gameplay LemonadeStand = new Gameplay();
            LemonadeStand.RunGame();

        }
    }
}
