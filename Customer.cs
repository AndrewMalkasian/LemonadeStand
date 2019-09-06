using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LemondStandTest
{
    public class Customer
    {


        List<CustomerTraits> customers = new List<CustomerTraits>()
        {
            new CustomerTraits("Uma Bob"     , "Yucky Recipe"     , "Sunny" , 68),
            new CustomerTraits("Ash Ketchup" , "Grandma's Recipe" , "Sunny" , 74),
            new CustomerTraits("Greg Manly"  , "Grandma's Recipe" , "Sunny" , 72),
            new CustomerTraits("The One"     , "Yucky Recipe"     , "Cloudy", 70),
            new CustomerTraits("Stacy's Dad" , "Grandma's Recipe" , "Cloudy", 45),
            new CustomerTraits("Reggie White", "Grandma's Recipe" , "Sunny" , 10),
        };

        
        public List<CustomerTraits> FilterByWeather(List<CustomerTraits> buyingCustomers)
        {
            buyingCustomers.FindAll(Cust => Cust.weather == "sunny");
            foreach (CustomerTraits customer in customers)
            {
                Console.WriteLine(buyingCustomers);
            }
            return buyingCustomers;
        }
            
        //public List<CustomerTraits> FilterByWeather(List<CustomerTraits> buyingCustomers)
        //{

        //    foreach (CustomerTraits customer in customers)
        //    {
        //        if (customer.weather.Equals(Weather.thedaysweather))
        //        {
        //            buyingCustomers.Add(customer);
        //        }
        //    }
        //    return buyingCustomers;
        //}
        //public List<CustomerTraits> FilterByRecipe(List<CustomerTraits> buyingCustomers)
        //{

        //    foreach (CustomerTraits customer in customers)
        //    {
        //        if (customer.recipe.Equals(Weather.thedaysweather))
        //        {
        //            buyingCustomers.Add(customer);
        //        }
        //    }
        //    return buyingCustomers;

        //}
       
    }




    public class CustomerTraits
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









