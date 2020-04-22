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
        public int amountOfCups;
        public double pricePerCup; 

        //constructor (SPAWNER)
        public Recipe()
        {
            amountOfIceCubes = 3;
            amountOfLemons = 3;
            amountOfSugarCubes = 3;
            amountOfCups = 10;
            pricePerCup = .75;
        }
        //member methods (CAN DO)
        public void AskRecipe()
        {
            Console.WriteLine("Please choose how many sugar cubes you want in a pitcher:");
            int amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose how many lemons you want in a pitcher:");
            int amountOfLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose how much ice you want in a pitcher:");
            int amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the price per cup of lemonade:");
            double pricePerCup = double.Parse(Console.ReadLine());

            Console.WriteLine("One pitcher pours 10 cups.");
        }


    }
}
