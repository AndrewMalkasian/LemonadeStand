using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Store
    {
        
        Dictionary<string, StoreItem> dictionaryStoreInventory = new Dictionary<string, StoreItem>(){
                {Cups25.choiceID, Cups25},{},{},
                {},{},{},
                {},{},{},
                {},{},{},
                };

        S
        //if(dictionaryStoreInventory.ContainsKey(userInput)) ((instead of switch/multiple if/else) 
        //{  
        //  //method to subtract their purchase from the wallet
        //}
        public Store()
        {
            StoreItem Cups25 = new StoreItem
            {
                choiceID = "1",
                name = "25 Paper Cups",
                cost = .77
            };
            StoreItem Cups50 = new StoreItem
            {
                choiceID = "2",
                name = "50 Paper Cups",
                cost = 1.52
            };
            StoreItem cups100 = new StoreItem
            {
                choiceID = "3",
                name = "100 Paper Cups",
                cost = 2.77
            };
            StoreItem lemons10 = new StoreItem
            {
                choiceID = "4",
                name = "10 Lemons",
                cost = .53

            };
            StoreItem lemons30 = new StoreItem
            {
                choiceID = "5",
                name = "30 Lemons",
                cost = 2.34

            };
            StoreItem lemons70 = new StoreItem
            {
                choiceID = "6",
                name = "70 Lemons",
                cost = 4.06

            };
            StoreItem sugar08 = new StoreItem
            {
                choiceID = "7",
                name = "8 Cups of Sugar",
                cost = .64

            };
            StoreItem sugar20 = new StoreItem
            {
                choiceID = "8",
                name = "20 Cups of Sugar",
                cost = 1.61

            };
            StoreItem sugar40 = new StoreItem
            {
                choiceID = "9",
                name = "40 Cups of Sugar",
                cost = 3.20
            };
            StoreItem IceCubes100 = new StoreItem
            {
                choiceID = "10",
                name = "100 Ice Cubes",
                cost = .87
            };
            StoreItem IceCubes200 = new StoreItem
            {
                choiceID = "11",
                name = "200 Ice Cubes",
                cost = 1.87
            };
            StoreItem IceCubes500 = new StoreItem
            {
                choiceID = "12",
                name = "500 Ice Cubes",
                cost = 3.97
            };






        } 
        public void BuyingItems()
        {
            purchaseCompleted = playerOne.wallet -
        }
        public void PurchasingMenu(Player playerOne)
        {
            Console.WriteLine("You get to Wal-Mart early in the morning before the day");
            Console.WriteLine($"{playerOne.wallet}");
            Console.WriteLine("1: Cups");
            Console.WriteLine("2: Lemons");
            Console.WriteLine("3: Cups of Sugar");
            Console.WriteLine("4: Ice Cubes");
            Console.WriteLine("---");
            Console.WriteLine("5:Begin the day");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case 1:
                {
                    BuyCupsMenu();
                }
                case 2:
                {
                    BuyLemonsMenu();
                }
                case 3:
                {
                    BuySugarMenu();
                }
                case 4:
                {
                    BuyIceCubesMenu();
                }
                case 5:
                {
                    BeginTheDay();
                }
            }

        }

        public void BuyCupsMenu()
        {
            Console.WriteLine("25 cups for $1 or 100 cups for $3?");
            string userInput = Console.ReadLine();
            if (userInput == "25")
            {

            }
            if (userInput == "100")
            {

            }
            else()
            {
                PurchasingMenu();
            }
        }
        public void BuyLemonsMenu()
        {

        }
        public void BuySugarMenu()
        {

        }

        public void BuyIceCubesMenu()
        {

        }

        



        //push into list that is their inventory
    }
}