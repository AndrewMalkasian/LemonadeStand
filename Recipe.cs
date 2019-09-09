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
        public string recipeCreated;
        public string lemonRecipeCost;
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
            recipeCreated = UI.RecipePrinted(playerOne);
           
        }





        //most likely goes into UI


    }

       

        

}

