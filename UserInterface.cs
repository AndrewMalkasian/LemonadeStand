using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public static class UserInterface
    {
        public static void MainMenu()
        {
            Console.WriteLine("How long would you like to play?");
            Console.WriteLine("Right now is only 1 day. Sorry");
            Console.WriteLine("Please press '1'.");
        }
        
        public static void PurchasingMenu()
        {
            Console.WriteLine("You get to Wal-Mart early in the morning before the day");
            Console.WriteLine($"Player's current capital: ${playerOne.wallet}");
            Console.WriteLine("You have the option to buy the following:");
            Console.WriteLine("1 : 25  Paper Cups   ");
            Console.WriteLine("2 : 50  Paper Cups   ");
            Console.WriteLine("3 : 100 Papers Cups  ");
            Console.WriteLine("4 : 10  Lemons       ");
            Console.WriteLine("5 : 30  Lemons       ");
            Console.WriteLine("6 : 70  Lemons       ");
            Console.WriteLine("7 : 8   Cups of Sugar");
            Console.WriteLine("8 : 20  Cups of Sugar");
            Console.WriteLine("9 : 40  Cups of Sugar");
            Console.WriteLine("10: 100 Ice Cubes    ");
            Console.WriteLine("11: 200 Ice Cubes    ");
            Console.WriteLine("12: 500 Ice Cubes    ");
            Console.WriteLine("---------------------");
            Console.WriteLine("13:Begin the day");
        }
    }
}
