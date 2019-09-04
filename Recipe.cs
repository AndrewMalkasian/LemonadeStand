using System;
using System.Collections.Generic;
using System.Text;

namespace LemondStandTest
{
    public class Recipe
    {
        int lemons;
        int sugar;
        int iceCubes;
        public Recipe()
        {

        }
        //todo: create recipes
        public void Recipes()
        {
            if ((lemons >= 4 && lemons <= 6) && (sugar >= 4 && sugar <= 6))
            {
                Console.WriteLine("Great");
            }
            if (lemons < 3 || sugar < 3)
            {
                Console.WriteLine("Nasty");
            }
            else if (lemons > 7 || sugar > 7)
            {
                Console.WriteLine("Nasty");
            }
            else
            {

            }
        }
        
       
    }
}
