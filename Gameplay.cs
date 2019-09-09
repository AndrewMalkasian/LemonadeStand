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


        public Gameplay()
        {
            playerOne = new Player();
            day = new Day();

        }
        public void RunGame()
        {
            BuyOrMakeLemonade(playerOne);


            //StartTheDay();


        }
        public void BuyOrMakeLemonade(Player playerOne)
        {
            string userInput = UI.WouldYouLikeToBuyOrMakeYourRecipe();
            if (userInput == "1")
            {
                PurchasingMenu(playerOne);
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

        public void PurchasingMenu(Player playerOne)
        {
            string userInput = UI.PurchasingMenuOne(playerOne);

            foreach (StoreItem storeItem in playerOne.store.itemsForSaleMenu)
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

            //UI.PurchasingMenuTwo(playerOne);
            //BuyOrMakeLemonade(playerOne);

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
        public void MainMenu()
        {
            UI.MainMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                PurchasingMenu(playerOne);
            }
            else if (userInput == "2")
            {
                UI.Rules();
            }
        }


    }



}

