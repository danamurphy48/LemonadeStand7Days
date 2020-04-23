using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables (HAS A)
        private List<string> names;
        public string name;
        public int buyingMultiplier;
        public int conditionPreference;
        public int temperaturePreference;

        //constructor (SPAWNER)
        public Customer()
        {
            //this.name = name;
            names = new List<string>();
            PopulateCustomerNames();
        }
        //member methods (CAN DO)
        public void PopulateCustomerNames()
        {
            for (int i = 0; i < 100; i++) 
            {
                name = "customer" + i;
                names.Add(name);
            }
        }
        //have customer preferences determined by randomization
        public void BuyLemonade(Player player, Pitcher pitcher, double pricePerCup)
        {
            pitcher.cupsLeftInPitcher--;
            player.wallet.Money += pricePerCup;            
        }

    }
}
