using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;  //shouldn't this be int amountOfCups?

        //constructor (SPAWNER)
        public Recipe()
        {
            amountOfIceCubes = 3;
            amountOfLemons = 3;
            amountOfSugarCubes = 3;
            pricePerCup = .75;
        }
        //member methods (CAN DO)
        //ask user to set price per cup and amount of ingredients per pitcher?


    }
}
