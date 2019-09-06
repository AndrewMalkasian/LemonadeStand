using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LemondStandTest
{
    public class Customer
    {


       public List<CustomerTraits> customers = new List<CustomerTraits>()
        {
            new CustomerTraits("Uma Bob"     , "Yucky Recipe"     , "Sunny" , 68),
            new CustomerTraits("Ash Ketchup" , "Grandma's Recipe" , "Sunny" , 74),
            new CustomerTraits("Greg Manly"  , "Grandma's Recipe" , "Sunny" , 72),
            new CustomerTraits("The One"     , "Yucky Recipe"     , "Cloudy", 70),
            new CustomerTraits("Stacy's Dad" , "Grandma's Recipe" , "Cloudy", 45),
            new CustomerTraits("Reggie White", "Grandma's Recipe" , "Sunny" , 10),
        };

        
        //public List<CustomerTraits> FilterByWeather(List<CustomerTraits> buyingCustomers)
        //{
        //    customers.FindAll(Cust => Cust.weather == "sunny");
        //    return buyingCustomers;
        //    foreach (CustomerTraits customer in customers)
        //    {
        //        Console.WriteLine(buyingCustomers);
        //    }
        //    return buyingCustomers;

        //}



        public List<CustomerTraits> FilterByWeather2(List<CustomerTraits> potentialCustomers, Weather weather)
        {
            List<CustomerTraits> buyingCustomers = new List<CustomerTraits>();

            foreach (CustomerTraits customer in potentialCustomers)
            {
                if (customer.weather.Equals(weather.theWeather))
                {
                    buyingCustomers.Add(customer);
                }
            }
            return buyingCustomers;

            //for(int i = 0; i < potentialCustomers.Count; i++)
            //{
            //    // do the stuff
            //}
            //return buyingCustomers;
            //}
           
        }
        public List<CustomerTraits> FilterByRecipe(List<CustomerTraits> potentialCustomers, Player playerOne)
        {
            List<CustomerTraits> buyingCustomers = new List<CustomerTraits>();
            foreach (CustomerTraits customer in potentialCustomers)
            {
                if (customer.recipe.Equals(playerOne.recipe))
                {
                    buyingCustomers.Add(customer);
                }
            }
            return buyingCustomers;

        }

        public void CustomersThatBought(List<CustomerTraits> buyingCustomers)
            {
                foreach (CustomerTraits customer in buyingCustomers)
                {
                    Console.WriteLine(customer.name);
                };
            }

        public void TestMethod (List<CustomerTraits> buyingCustomers, List<CustomerTraits>potentialCustomers, Weather weather, Player playerOne)
        {
            FilterByWeather2(potentialCustomers, weather);
            FilterByRecipe(potentialCustomers, playerOne);
            CustomersThatBought(buyingCustomers);

        }
    }




   
}









