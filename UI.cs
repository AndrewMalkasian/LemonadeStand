using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public static class UI
    {
        public static void StartMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");

        }
        public static void MainMenu()
        {
            Console.WriteLine("How long would you like to play?");
            Console.WriteLine("Right now is only 1 day. Sorry");
            Console.WriteLine("Please press '1'.");
        }

       
        public static void PurchasingMenuOne(Player playerOne)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You get to Wal-Mart early in the morning before the day");
            Console.WriteLine($"Player's current capital: {playerOne.wallet}");
            Console.WriteLine("You have the option to buy the following:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 : 25  Paper Cups    |$  .77");
            Console.WriteLine("2 : 50  Paper Cups    |$ 1.52");
            Console.WriteLine("3 : 100 Papers Cups   |$ 2.77");
            Console.WriteLine("4 : 10  Lemons        |$  .53");
            Console.WriteLine("5 : 30  Lemons        |$ 2.34");
            Console.WriteLine("6 : 70  Lemons        |$ 4.06");
            Console.WriteLine("7 : 8   Cups of Sugar |$  .64");
            Console.WriteLine("8 : 20  Cups of Sugar |$ 1.61");
            Console.WriteLine("9 : 40  Cups of Sugar |$ 3.20");
            Console.WriteLine("10: 100 Ice Cubes     |$  .87");
            Console.WriteLine("11: 200 Ice Cubes     |$ 1.87");
            Console.WriteLine("12: 500 Ice Cubes     |$ 3.97");
        }


        public static void PurchasingMenuTwo(Player playerOne)
        {
            Console.WriteLine("---------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--CURRENT INVENTORY--");
            Console.WriteLine($"NOTE: Last chance to buy! Player's current capital: ${playerOne.wallet}");
            Console.WriteLine($"Cups: {playerOne.inventory.cupsOwned}");
            Console.WriteLine($"Lemons: {playerOne.inventory.lemonsOwned}");
            Console.WriteLine($"Cups o' Sugar: {playerOne.inventory.sugarOwned}");
            Console.WriteLine($"Ice Cubes: {playerOne.inventory.iceCubesOwned}");
    
        }
           



    }



}



