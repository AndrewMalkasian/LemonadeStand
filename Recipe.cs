using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Recipe
    {
        Day day = new Day();

        public int recipeLemonsTotal;
        public int recipeSugarTotal;
        public int recipeIceCubesTotal;
        public string grandmasRecipe;
        public string yuckyRecipe;
        public Recipe()
        {
      
     
        }
        public void LemonRecipe(Player playerOne)
        {
            Console.WriteLine("How many Lemons should you use?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            playerOne.recipe.recipeLemonsTotal = userInput;
            playerOne.inventory.lemonsOwned -= playerOne.recipe.recipeLemonsTotal;  
        }
        public void SugarRecipe(Player playerOne)
        {
            Console.WriteLine("How many Sugar should you use?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            playerOne.recipe.recipeSugarTotal = userInput;
            playerOne.inventory.lemonsOwned -= playerOne.recipe.recipeSugarTotal;
        }
        public void IceCubesRecipe(Player playerOne)
        {
            Console.WriteLine("How many Ice Cubes should you use?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            playerOne.recipe.recipeIceCubesTotal = userInput;
            playerOne.inventory.lemonsOwned -= playerOne.recipe.recipeIceCubesTotal;
        }

       

        public void MainRecipe(Player playerOne)
        {

            LemonRecipe(playerOne);
            SugarRecipe(playerOne);
            IceCubesRecipe(playerOne);
            RecipePrinted(playerOne);
            StartTheDay();
            
           
           
        }

        //most likely goes into UI
        public string RecipePrinted(Player playerOne)
        {
            Console.WriteLine($"Total Lemons in Recipe:        {playerOne.recipe.recipeLemonsTotal}   ");
            Console.WriteLine($"Total Cups of Sugar in Recipe: {playerOne.recipe.recipeSugarTotal}    ");
            Console.WriteLine($"Total Ice Cubes in Recipe:     {playerOne.recipe.recipeIceCubesTotal} ");
            if ((playerOne.recipe.recipeLemonsTotal >= 1 && playerOne.recipe.recipeLemonsTotal <= 5) && (playerOne.recipe.recipeSugarTotal >= 1 && playerOne.recipe.recipeSugarTotal <= 5) && playerOne.recipe.recipeIceCubesTotal > 0)
            {
                Console.WriteLine("grandma's recipe");
                return grandmasRecipe;

            }

            else
            {
                Console.WriteLine("yucky recipe ");
                return yuckyRecipe;
            }


        }

        public void StartTheDay()
        {
            Console.WriteLine("Let's start the day!");
            List<CustomerTraits> buyingCustomers = null;
            day.customer.FilterByWeather(buyingCustomers);
        }



    }
}
