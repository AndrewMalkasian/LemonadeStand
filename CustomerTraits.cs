using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{


         public class CustomerTraits : Customer
         {
            public string name;
            public string recipe;
            public string weather;
            public int temp;
            public CustomerTraits(string name, string recipe, string weather, int temp)
            {

                this.name = name;
                this.recipe = recipe;
                this.weather = weather;
                this.temp = temp;

            }
         }
}

