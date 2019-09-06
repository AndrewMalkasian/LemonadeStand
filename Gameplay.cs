using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Gameplay
    {
        public Player playerOne = new Player();
        public Day day = new Day();
       
        
        


        public Gameplay()
        {

        }
        public void RunGame()
        {

            playerOne.LemonadeStore.BuyOrMakeLemonade(playerOne);
          

        }

        public void StartMenu()
        {
            //UI.StartMenu();
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                playerOne.LemonadeStore.PurchasingMenu(playerOne);
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
                playerOne.LemonadeStore.PurchasingMenu(playerOne);
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

