using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class PlayerInventory
    {
        int AmountOfLemons = 0;
        int AmountOfSugar = 0;
        int AmountOfIceCubes = 0;
        
        
        public PlayerInventory()
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
           //TODO: remove from inventory after 1 days
        }
        public void SugarShelfLife()
        {
            //TODO: remove from inventory after 1 days
        }
        public void IceCubeShelfLife()
        {
            //TODO: remove from inventory after 1 days
        }

    }
}