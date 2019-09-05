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

        //most likely goes into UI
        public void RecipePrinted(Player playerOne)
        {
            Console.WriteLine($"Total Lemons in Recipe:        {playerOne.recipe.recipeLemonsTotal}   ");
            Console.WriteLine($"Total Cups of Sugar in Recipe: {playerOne.recipe.recipeSugarTotal}    ");
            Console.WriteLine($"Total Ice Cubes in Recipe:     {playerOne.recipe.recipeIceCubesTotal} ");


        }



    }
}
