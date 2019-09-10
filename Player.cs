using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    
    public class Player
    {
        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public Store store = new Store();

        public double startingWallet = 20;
        public int earnings;


        public Player()
        { 
        
            
        }


        //didn't have time to finish this:
        //public void Earnings()
        //{
        //    earnings = startingWallet - totalCosts + customerEarnings;  
        //}
       


    }

}