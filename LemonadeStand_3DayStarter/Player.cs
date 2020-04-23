using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;



        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();

        }

        // member methods (CAN DO)
        public void PickName()
        {
            Console.WriteLine("Player name:");
            name = Console.ReadLine();
        }
        public void MakePitcher(Recipe recipe)
        {
            if (inventory.lemons.Count >= recipe.amountOfLemons)
            {
                inventory.lemons.RemoveRange(0, recipe.amountOfLemons);
            }
            if (inventory.sugarCubes.Count >= recipe.amountOfSugarCubes)
            {
                inventory.lemons.RemoveRange(0, recipe.amountOfSugarCubes);
            }
            if (inventory.iceCubes.Count >= recipe.amountOfIceCubes)
            {
                inventory.iceCubes.RemoveRange(0, recipe.amountOfIceCubes);
            }
            if (inventory.cups.Count >= recipe.amountOfCups)
            {
                inventory.cups.RemoveRange(0, recipe.amountOfCups);
            }
        }
    }
}
