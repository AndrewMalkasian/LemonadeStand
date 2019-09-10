using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Gameplay
    {
        public Player playerOne;
        public Day day;
        public string recipeCreated;
        public int daysPlaying;
        public bool willContinueShopping;

        public Gameplay()
        {
            playerOne = new Player();
            day = new Day();
            willContinueShopping = true;

        }
        public void RunGame()
        {
            UI.StartingInventoryView(playerOne);
            int userInput = UI.AskForTheNumberOfPlayDays();
            if (userInput <= 7)
            { 
                for (byte i = 0; i < userInput; i++)
                {
                    BuyOrMakeLemonade(playerOne);
                }
            }
            else
            {
                Console.WriteLine("You only have the stamina to go 7 days. Please choose a number between 1 and 7.");
                RunGame();
            }


            //StartTheDay();


        }
        public void BuyOrMakeLemonade(Player playerOne)
        {
            string userInput = UI.WouldYouLikeToBuyOrMakeYourRecipe();
            if (userInput == "1")
            {
                while (willContinueShopping)
                {
                    PurchasingMenu(playerOne);
                    WantsToShop();
                }

                BuyOrMakeLemonade(playerOne);
            }
            else if (userInput == "2")
            {
                playerOne.recipe.MainRecipe(playerOne);

                day.StartTheDay(playerOne);

}
            else
            {
                BuyOrMakeLemonade(playerOne);
            }

        }


        public void WantsToShop()
        {
            Console.WriteLine("Continue shopping? yes (1) or go to your recipe (2)");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                willContinueShopping = true;
            }
            else if (userInput == "2")
            {
                willContinueShopping = false;
                playerOne.recipe.MainRecipe(playerOne);
            }
            else
            {
                Console.WriteLine("enter 1 or 2. I don't have time for this.");
                WantsToShop();
            }
        }
        public void PurchasingMenu(Player playerOne)
        {
            string userInput = UI.PurchasingMenuOne(playerOne);

            foreach (StoreItem storeItem in playerOne.store.itemsForSaleMenu)
            {
                if (userInput.Equals(storeItem.keyId))
                {
                    Console.WriteLine($"You've purchased {storeItem.name}.");
                    playerOne.startingWallet -= storeItem.cost;
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

        }

        //public void StartMenu()
        //{
        //    //UI.StartMenu();
        //    string userInput = Console.ReadLine();
        //    if (userInput == "1")
        //    {
        //        playerOne.store.PurchasingMenu(playerOne);
        //    }
        //    else
        //    {
        //        MainMenu();
        //    }
        //}
        //public void MainMenu()
        //{
        //    int userInput = UI.MainMenu();
           
               
                    
        //}

    }


}





