using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Customer
    {
        public string Name { get; set; }
        public string FavoriteRecipe { get; set; }
        public string FavoriteForecast { get; set; }
        public bool WillBuy { get; set; }
        public Customer(string name, string favoriteRecipe, string favoriteForecast, bool willBuy)   
        {
            Name = name;
            FavoriteRecipe = favoriteRecipe;
            FavoriteForecast = favoriteForecast;
            WillBuy = true;


        }
        
   
    }
}