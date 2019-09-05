using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Gameplay
    {
        public Player playerOne = new Player();
        public Inventory inventory = new Inventory();
        public Store LemonadeStore = new Store();
        
        


        public Gameplay()
        {

        }
        public void RunGame()
        {
           
            LemonadeStore.PurchasingMenu(playerOne, inventory);
          

        }

        public void StartMenu()
        {
            //UI.StartMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                LemonadeStore.PurchasingMenu(playerOne, inventory);
            }
            else
            {
                MainMenu();
            }
        }
        public void MainMenu()
        {
            UI.MainMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                LemonadeStore.PurchasingMenu(playerOne, inventory);
            }
            else if (userInput == "2")
            {
                
            }
        }
        public void Rules()
        {
            //TODO: MAKE RULES
        }
    }

    

}

