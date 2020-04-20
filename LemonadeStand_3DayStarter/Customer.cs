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
        
        //constructor (SPAWNER)
        public Customer(string name)
        {
            this.name = name;
            names = new List<string>();
            PopulateCustomerNames();
        }
        //member methods (CAN DO)
        public void PopulateCustomerNames()
        {
            names.Add("Marco Polo");
            names.Add("Princess Leia");
            names.Add("Amelia Earhart");
            names.Add("Darth Siddius");
            names.Add("Obi Wan Kenobi");
            names.Add("Padme Amidala");
            names.Add("Bill Gates");
            names.Add("Melinda Gates");
        }
        public bool BuyLemonade()
        {

            return true;
        }
    }
}
