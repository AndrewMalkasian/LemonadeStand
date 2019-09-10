using System;
using System.Collections.Generic;

namespace LemondStandTest
{
    class Program
    {
        static void Main(string[] args)
        {


            Gameplay LemonadeStand = new Gameplay();
            LemonadeStand.RunGame();


        }
    }
    //SOLID Principles: 

    // OPEN/CLOSED - building CustomerTraits the way I did was so it was expandable and you are able to add additional parameters
    // when you need to complete a task. in example: buyingPower, their favorite weather, their favorite recipe all interact with
    // the system and if given enough time the way it was set up had a lot of potential. Although, this is a very basic game and 
    // doesn't function to the scope of the userstory, I've tried to make it to where if/when I come back these lists will allow for
    // easy access into making the project shine.

    //SINGLE RESPONSIBILITY PRINCIPLE: This is my first time at trying my hand at the SOLID's
    // and I did my best to make the store single responsibility, I felt was best placed inside a list.
    // The store only holds the list of items for sale and that is it's sole responsibility.
}
