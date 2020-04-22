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

            Console.WriteLine("The pitcher cannot exceed 9 ingredients, but can be any combination of Ice Cubes, Sugar Cubes, and Lemons.");
            Console.WriteLine("How many pitchers do you want to make?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A pitcher holds 10 cups of lemonade.");
        }
        //member methods
        public void MakePitcher(Player player, Recipe recipe)
        {
            if(player.inventory.lemons.Count >= recipe.amountOfLemons)
            {
                player.inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            }
            if(player.inventory.sugarCubes.Count >= recipe.amountOfSugarCubes)
            {
                player.inventory.lemons.RemoveRange(0, recipe.amountOfSugarCubes);
            }
            if(player.inventory.iceCubes.Count >= recipe.amountOfIceCubes)
            {
                player.inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
            }
            //if(player.inventory.cups.Count >= recipe.pricePerCup)
            //{
            //    player.inventory.cups.RemoveRange(0, recipe.pricePerCup);
            //}
        }

        public void PourLemonadeIntoCup(Player player, Inventory inventory)
        {
            if (player.inventory.cups.Count >= cupsLeftInPitcher)
            {
                player.inventory.cups.RemoveRange(0, cupsLeftInPitcher);
            }
        }
        //public void PourPitcher()
        //{
        //    for (int i = 10; i > 0; i--)
        //    {
        //        int cupsLeftInPitcher = i;
        //    }
        //}
        //need method to refill pitcher based on current inventory
        //Or do I need to think about this like 1 pitcher = 3 lemons + 3 ice + 3 sugar + 10 cups
        //Do I need to set this limit?
    }
}
            //Pitcher pitcher = new Pitcher();
            //pitcher = amountOfLemons + amountOfSugarCubes + amountOfIceCubes;
            // = 9;