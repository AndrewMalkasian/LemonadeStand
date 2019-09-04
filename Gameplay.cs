using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Gameplay
    {
        public Player playerOne = new Player();
        public Store LemonadeStore = new Store();


        public Gameplay()
        {

        }
        public void RunGame()
        {
            UserInterface.MainMenu();
            MainMenu();
           


        }

        public void MainMenu()
        {
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                UserInterface.PurchasingMenu(playerOne);
            }
            else
            {
                UserInterface.MainMenu();
            }
        }
        public void Rules()
        {
            //TODO: MAKE RULES
        }
    }

    

}

