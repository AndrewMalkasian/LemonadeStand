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
                if (userInput.Equals(storeItem.keyId))
                {
                    Console.WriteLine($"You've purchased {storeItem.name}");
                    playerOne.wallet -= storeItem.cost;
                    Console.WriteLine($"You now have {playerOne.wallet} dollars");
                    UserInterface.PurchasingMenu(playerOne);
                    PurchasingMenu(playerOne);
                }
            };
                

        }

        List<StoreItem> itemsForSale = new List<StoreItem>()
        {
                new StoreItem("1", "25 Paper Cups",   .77),
                new StoreItem("2", "50 Paper Cups",  1.52),
                new StoreItem("3", "100 Paper Cups", 2.77),

                new StoreItem("4", "10 Lemons",  .53),
                new StoreItem("5", "30 Lemons", 2.34),
                new StoreItem("6", "70 Lemons", 4.06),

                new StoreItem("7",  "8 Cups of Sugar",  .64),
                new StoreItem("8", "20 Cups of Sugar", 1.61),
                new StoreItem("9", "40 Cups of Sugar", 3.20),
               
                new StoreItem("10", "100 Ice Cubes", .87),
                new StoreItem("11", "200 Ice Cubes", 1.87),
                new StoreItem("12", "500 Ice Cubes", 3.97),
        };


    }
           
        
      
}
            
        
            
     
            


        


        //push into list that is their inventory
    
