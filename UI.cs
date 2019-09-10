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
        public static int MainMenu()
        {
            Console.WriteLine("How long would you like to play?");
            Console.WriteLine("1 or 7 days");
            Console.WriteLine("Please press '1' or '7'.");
            return int.Parse(Console.ReadLine());
        }


        public static string PurchasingMenuOne(Player playerOne)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You get to Wal-Mart early in the morning before the day");
            Console.WriteLine($"Player's current capital: {playerOne.startingWallet}");
            Console.WriteLine("You have the option to buy the following:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 : 25  Paper Cups    |$  .77");
            Console.WriteLine("2 : 50  Paper Cups    |$ 1.52");
            Console.WriteLine("3 : 100 Papers Cups   |$ 2.77");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("4 : 10  Lemons        |$  .53");
            Console.WriteLine("5 : 30  Lemons        |$ 2.34");
            Console.WriteLine("6 : 70  Lemons        |$ 4.06");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("7 : 8   Cups of Sugar |$  .64");
            Console.WriteLine("8 : 20  Cups of Sugar |$ 1.61");
            Console.WriteLine("9 : 40  Cups of Sugar |$ 3.20");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("10: 100 Ice Cubes     |$  .87");
            Console.WriteLine("11: 200 Ice Cubes     |$ 1.87");
            Console.WriteLine("12: 500 Ice Cubes     |$ 3.97");
            return Console.ReadLine();

        }


        public static void PurchasingMenuTwo(Player playerOne)
        {
            Console.WriteLine("---------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--CURRENT INVENTORY--");
            Console.WriteLine($"NOTE: Last chance to buy! Player's current capital: ${playerOne.startingWallet}");
            Console.WriteLine($"Cups: {playerOne.inventory.cupsOwned}");
            Console.WriteLine($"Lemons: {playerOne.inventory.lemonsOwned}");
            Console.WriteLine($"Cups o' Sugar: {playerOne.inventory.sugarOwned}");
            Console.WriteLine($"Ice Cubes: {playerOne.inventory.iceCubesOwned}");
            Console.WriteLine("enter another selection?");

        }



        public static string WouldYouLikeToBuyOrMakeYourRecipe()
        {
            Console.WriteLine("Would you like to (1)buy supplies, (2) Make your lemonade's recipe?");
            return Console.ReadLine();
        }
        public static string RecipePrinted(Player playerOne)
        {
            Console.WriteLine($"Total Lemons in Recipe:        {playerOne.recipe.recipeLemonsTotal}   ");
            Console.WriteLine($"Total Cups O' Sugar in Recipe: {playerOne.recipe.recipeSugarTotal}    ");
            Console.WriteLine($"Total Ice Cubes in Recipe:     {playerOne.recipe.recipeIceCubesTotal} ");
            if (playerOne.recipe.recipeLemonsTotal > 1 && playerOne.recipe.recipeSugarTotal > 1)
            {
                Console.WriteLine("Grandma's Recipe");
                return "Grandma's Recipe";

            }

            else
            {
                Console.WriteLine("Yucky Recipe ");
                return "Yucky Recipe";
            }
        }
        public static int AskForTheNumberOfPlayDays()
        {
            Console.WriteLine("How many days will you be playing? (up to 7 days)");
            return int.Parse(Console.ReadLine());

        }

        public static void StartingInventoryView(Player playerOne)
        {
            Console.WriteLine($"Cups: {playerOne.inventory.cupsOwned}");
            Console.WriteLine($"Lemons: {playerOne.inventory.lemonsOwned}");
            Console.WriteLine($"Cups o' Sugar: {playerOne.inventory.sugarOwned}");
            Console.WriteLine($"Ice Cubes: {playerOne.inventory.iceCubesOwned}");
        }

        public static int HowMuchSugarWouldYouLike()
        {
            Console.WriteLine("How many Sugar should you use?");
           return Convert.ToInt32(Console.ReadLine());
        }

        public static int HowMuchLemonsWouldYouLike()
        {
            Console.WriteLine("How many Lemons should you use?");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int HowManyIceCubesWouldYouLike()
        {
            Console.WriteLine("How many Ice Cubes should you use?");
            return Convert.ToInt32(Console.ReadLine());
        }

       
        public static void Rules()
        {
            //TODO: MAKE RULES
        }
    }
}



