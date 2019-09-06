using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Store
    {
        public Recipe recipe = new Recipe();
        public Store()
        {
           
          
        }
        public void BuyOrMakeLemonade(Player playerOne)
        {
            Console.WriteLine("Would you like to (1)buy supplies, (2) Make your lemonade's recipe?");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                PurchasingMenu(playerOne);
            }
            else if (userInput == "2")
            {
                playerOne.recipe.MainRecipe(playerOne);
            }
            else
            {
                BuyOrMakeLemonade(playerOne);
            }

        }
        public void PurchasingMenu(Player playerOne)
        {
           
            UI.PurchasingMenuOne(playerOne);
            string userInput = Console.ReadLine();
            foreach (StoreItem storeItem in itemsForSaleMenu)
                {  
                    if (userInput.Equals(storeItem.keyId))
                    {   
                        Console.WriteLine($"You've purchased {storeItem.name}.");
                        playerOne.wallet -= storeItem.cost;
                        if (storeItem.name.Contains("Paper Cups"))
                        {
                            playerOne.inventory.cupsOwned += storeItem.totalProductBought;
            
                        }
                        else if (storeItem.name.Contains("Lemons"))
                        {
                            playerOne.inventory.lemonsOwned += storeItem.totalProductBought;
                            
                        }
                        else if (storeItem.name.Contains("Sugar"))
                        {
                            playerOne.inventory.sugarOwned += storeItem.totalProductBought;
                        }
                        else if (storeItem.name.Contains("Ice Cube"))
                        {
                            playerOne.inventory.iceCubesOwned += storeItem.totalProductBought;
                        
                        }
               
                    }
                       
            };

                    UI.PurchasingMenuTwo(playerOne);
                    BuyOrMakeLemonade(playerOne);

        }

        List<StoreItem> itemsForSaleMenu = new List<StoreItem>()
        {


                new StoreItem("1", "25 Paper Cups",   .77, 25),
                new StoreItem("2", "50 Paper Cups",  1.52, 50),
                new StoreItem("3", "100 Paper Cups", 2.77, 100),

                new StoreItem("4", "10 Lemons",  .53, 10),
                new StoreItem("5", "30 Lemons", 2.34, 30),
                new StoreItem("6", "70 Lemons", 4.06, 70),

                new StoreItem("7",  "8 Cups of Sugar",  .64, 8),
                new StoreItem("8", "20 Cups of Sugar", 1.61, 20),
                new StoreItem("9", "40 Cups of Sugar", 3.20, 40),

                new StoreItem("10", "100 Ice Cubes", .87,  100),
                new StoreItem("11", "200 Ice Cubes", 1.87, 200),
                new StoreItem("12", "500 Ice Cubes", 3.97, 500),

                new StoreItem ("14", "Recipe",0,0),
        };


    }
           
        
      
}
            
        
            
     
            


        


        //push into list that is their inventory
    
