using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables
        public int cupsLeftInPitcher;
        public Inventory inventory;


        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 10;
            //pitcher ingredient amount necessary?
            Console.WriteLine("The pitcher cannot exceed 9 ingredients, but can be any combination of Ice Cubes, Sugar Cubes, and Lemons.");
            Console.WriteLine("How many pitchers do you want to make?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A pitcher holds 10 cups of lemonade.");
        }
        //member methods
        public void MakePitcher(Player player, Recipe recipe)
        {
            if (player.inventory.lemons.Count >= recipe.amountOfLemons)
            {
                player.inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            }
            if (player.inventory.sugarCubes.Count >= recipe.amountOfSugarCubes)
            {
                player.inventory.lemons.RemoveRange(0, recipe.amountOfSugarCubes);
            }
            if (player.inventory.iceCubes.Count >= recipe.amountOfIceCubes)
            {
                player.inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
            }
            if (player.inventory.cups.Count >= recipe.amountOfCups)
            {
                player.inventory.cups.RemoveRange(0, recipe.amountOfCups);
            }
        }
    }
}
