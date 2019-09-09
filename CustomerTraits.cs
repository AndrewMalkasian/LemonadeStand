using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{


         public class CustomerTraits
         {
            public string name;
            public string recipe;
            public string weather;
            public int temp;
            public double walletSize;
            public CustomerTraits(string name, string recipe, string weather, double walletSize)
            {

                this.name = name;
                this.recipe = recipe;
                this.weather = weather;
                this.walletSize = walletSize;
              

            }
         }
}

