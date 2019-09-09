using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Day
    {

        public Weather weather;
        public Customer customer;
        public List<CustomerTraits> buyingCustomers;
        public List<CustomerTraits> potentialCustomers;
        public Day()
        {
            weather = new Weather();
            customer = new Customer();
            potentialCustomers = new List<CustomerTraits>();
            buyingCustomers = new List<CustomerTraits>();
            //potentialCustomers = GenerateCustomers();

        }

        public List<CustomerTraits> customers = new List<CustomerTraits>()
        {
            new CustomerTraits("Uma Bob"     , "Yucky Recipe"     , "Sunny", .45 ),
            new CustomerTraits("Ash Ketchup" , "Grandma's Recipe" , "Sunny", .90 ),
            new CustomerTraits("Greg Manly"  , "Grandma's Recipe" , "Sunny", .75 ),
            new CustomerTraits("The One"     , "Yucky Recipe"     , "Cloudy", .47 ),
            new CustomerTraits("Stacy's Dad" , "Grandma's Recipe" , "Cloudy", 1.27 ),
            new CustomerTraits("Reggie White", "Grandma's Recipe" , "Sunny", .75  ),
        };
        public void StartTheDay(Player playerOne)
        {
            Console.WriteLine("Let's start the day!");
                weather.TrueWeather();
               TestMethod(buyingCustomers, potentialCustomers,weather, playerOne);
   
          
        }

        public List<CustomerTraits> FilterByWeather(List<CustomerTraits> potentialCustomers, Weather weather)
        {
            foreach (CustomerTraits customer in customers)
            {
                if (customer.weather.Equals(weather.theWeather))
                {
                    potentialCustomers.Add(customer);
                }
            }
            return potentialCustomers;

        }
        public List<CustomerTraits> FilterByRecipe(List<CustomerTraits> potentialCustomers, List<CustomerTraits> buyingCustomers, Player playerOne)
        {
            foreach (CustomerTraits customer in potentialCustomers)
            {
                if (customer.recipe.Equals(playerOne.recipe.recipeCreated))
                {
                    buyingCustomers.Add(customer);
                }
            }
            return buyingCustomers;

        }

        public void TestMethod(List<CustomerTraits> buyingCustomers, List<CustomerTraits> potentialCustomers, Weather weather, Player playerOne)
        {
            FilterByWeather(potentialCustomers, weather);
            FilterByRecipe(potentialCustomers, buyingCustomers, playerOne);
            CustomersThatBought(buyingCustomers, playerOne);

        }
        public void CustomersThatBought(List<CustomerTraits> buyingCustomers, Player playerOne)
        {
            foreach (CustomerTraits customer in buyingCustomers)
            {
                Console.WriteLine(customer.name);
                playerOne.wallet += customer.walletSize;
                Console.WriteLine($"{customer.walletSize} has been added to your Player wallet {playerOne.wallet}");
                

            };
        }

        public void DayEnds()
        {
            //earnings = multiple the List.(count) * Lemonade
            //display resultshj
        }
    }
 

       
}
