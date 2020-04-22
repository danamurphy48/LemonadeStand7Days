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
        public Store store;


        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            store = new Store();
        }

        // member methods (CAN DO)
        public void PickName()
        {
            Console.WriteLine("Player name:");
            name = Console.ReadLine();
        }
        public void GoToStore()
        {
            Console.WriteLine("Please purchase ingredients and cups to start your lemonade stand.");
            Console.WriteLine(wallet);
            store.SellLemons();

        }
    }
}
