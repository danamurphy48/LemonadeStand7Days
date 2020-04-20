using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {
            //DisplayCurrentWeather();
            weather = new Weather();
        }
        //member methods
        
        public void Forecast()
        {

        }
        public void CustomersPurchaseLemonade(Player player, double priceOfCup)
        {
            foreach(Customer customer in customers)
            {
                if (customer.BuyLemonade())
                {
                    player.wallet.Money += priceOfCup;
                }
            }
        }
        //weather algorithm
    }
}
