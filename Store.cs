using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Store
    {
        
        public Store()
        {
           
          
        } 
        public void PurchasingMenu(Player playerOne)
        {
       
            string userInput = Console.ReadLine();
            foreach (StoreItem storeItem in itemsForSale)
            {
                if (userInput.Equals(storeItem.keyID))
                {
                    Console.WriteLine($"You've purchased {storeItem.name}");
                    playerOne.wallet -= storeItem.cost;
                    Console.WriteLine($"You now have {playerOne.wallet} dollars");
                    UserInterface.PurchasingMenu(playerOne);
                }
            };
                

        }

        List<StoreItem> itemsForSale = new List<StoreItem>()
        {
                new StoreItem()
                {
                    keyID = "1",
                    name = "25 Paper Cups",
                    cost = .77
                },
                new StoreItem()
                {
                    keyID = "2",
                    name = "50 Paper Cups",
                    cost = 1.52
                },
                new StoreItem()
                {
                    keyID = "3",
                    name = "100 Paper Cups",
                    cost = 2.77
                },
                new StoreItem()
                {
                    keyID = "4",
                    name = "10 Lemons",
                    cost = .53
                },
                new StoreItem()
                {
                    keyID = "5",
                    name = "30 Lemons",
                    cost = 2.34
                },
                new StoreItem()
                {
                    keyID = "6",
                    name = "70 Lemons",
                    cost = 4.06
                },
                new StoreItem()
                {
                    keyID = "7",
                    name = "8 Cups of Sugar",
                    cost = .64
                },
                new StoreItem()
                {
                    keyID = "8",
                    name = "20 Cups of Sugar",
                    cost = 1.61
                },
                new StoreItem()
                {
                    keyID = "9",
                    name = "40 Cups of Sugar",
                    cost = 3.20
                },
                new StoreItem()
                {
                    keyID = "10",
                    name = "100 Ice Cubes",
                    cost = .87
                },
                new StoreItem()
                {
                    keyID = "11",
                    name = "200 Ice Cubes",
                    cost = 1.87
                },
                new StoreItem()
                {
                    keyID = "12",
                    name = "500 Ice Cubes",
                    cost = 3.97
                },
        };


    }
           
        
      
}
            
        
            
     
            


        


        //push into list that is their inventory
    
