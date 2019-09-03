using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Inventory
    {
        int AmountOfLemons;
        int AmountOfSugar;
        int AmountOfIceCubes;
        
        public Inventory()
        {

        }

        public void DisplayInventory()
        {
            Console.WriteLine($"Lemons: {AmountOfLemons} ");
            Console.WriteLine($"Sugar: {AmountOfSugar} ");
            Console.WriteLine($"Ice Cubes: {AmountOfIceCubes} ");


        }

        
        public void LemonShelfLife()
        {
           // remove from inventory after 2 days
        }
        public void SugarShelfLife()
        {
            // remove from inventory after 2 days
        }
        public void IceCubeShelfLife()
        {
            // remove from inventory after 1 days
        }

    }
}