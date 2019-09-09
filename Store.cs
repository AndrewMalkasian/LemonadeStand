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

        public List<StoreItem> itemsForSaleMenu = new List<StoreItem>()
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
    
