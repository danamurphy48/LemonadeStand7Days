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
        private List<string> groupOfNames;
        public string name;
        public int buyingMultiplier;
        public int conditionPreference;
        public int temperaturePreference;

        //constructor (SPAWNER)
        public Customer()
        {
            groupOfNames = new List<string>(); //{ "Dana", "Charles", "David"};
            PopulateCustomerNames();
            name = GetNameFromList();
        }
        //member methods (CAN DO)
        public void PopulateCustomerNames()
        {
            for (int i = 0; i < 100; i++) 
            {
                string tempName = "customer" + i;
                groupOfNames.Add(tempName);
            }
        }
        public string GetNameFromList()
        {
            Random random = new Random();
            int tempInt = random.Next(0, groupOfNames.Count - 1);
            string tempName = groupOfNames[tempInt];
            return tempName;
        }
        //have customer preferences determined by randomization
        public void BuyLemonade(Player player, Pitcher pitcher, double pricePerCup)
        {
            pitcher.cupsLeftInPitcher--;
            player.wallet.Money += pricePerCup;            
        }

    }
}
