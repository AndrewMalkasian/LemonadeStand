using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Gameplay
    {
        public Player playerOne;
        public Day day = new Day();
        public Customer customer = new Customer();
        public Weather weather = new Weather();
       
        
        


        public Gameplay()
        {
            playerOne = new Player();
        }
        public void RunGame()
        {
            StartMenu();
            playerOne.LemonadeStore.BuyOrMakeLemonade(playerOne);
            //StartTheDay();
          

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
        public void StartTheDay(List<CustomerTraits> buyingCustomers)
        {
            Console.WriteLine("Let's start the day!");
            buyingCustomers.Clear();
            customer.FilterByWeather(buyingCustomers);
        }
    }

    

}

