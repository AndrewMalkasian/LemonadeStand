using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Recipe
    {
        public int recipeLemonsTotal;
        public int recipeSugarTotal;
        public int recipeIceCubesTotal;
        public string grandmasRecipe;
        public string yuckyRecipe;
        public Recipe()
        {
            Console.WriteLine("test");
            //TODO: Make a method that places recipeLemons from InventoryLemons (sugar,IceCubes)
        }
         
        //todo: create recipes
        public void LemonRecipe(Player playerOne)
        {
            Console.WriteLine("How many Lemons should you use?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            recipeLemonsTotal = userInput;
            playerOne.inventory.lemonsOwned -= recipeLemonsTotal;  
        }
        public void SugarRecipe(Player playerOne)
        {
            Console.WriteLine("How many Sugar should you use?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            recipeSugarTotal = userInput;
            playerOne.inventory.lemonsOwned -= recipeSugarTotal;
        }
        public void IceCubesRecipe(Player playerOne)
        {
            Console.WriteLine("How many Ice Cubes should you use?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            recipeIceCubesTotal = userInput;
            playerOne.inventory.lemonsOwned -= recipeIceCubesTotal;
        }

       

        public string MainRecipe(Player playerOne)
        {

           if((playerOne.recipe.recipeLemonsTotal >= 1 && playerOne.recipe.recipeLemonsTotal <= 5 ) && (playerOne.recipe.recipeSugarTotal >= 1 && playerOne.recipe.recipeSugarTotal <= 5) && playerOne.recipe.recipeIceCubesTotal > 0)
           {

                return grandmasRecipe;

           }
            else
            {
                return yuckyRecipe;
            }

        }
        


    }
}
