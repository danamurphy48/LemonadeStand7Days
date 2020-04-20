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
        //public List<int> dayOfGame;
        private int dayOfGame;

        //constructor
        public Day()
        {
            //DisplayCurrentWeather();
            weather = new Weather();
            customers = new List<Customer>();
            //dayOfGame = new List<int>();
            DayOfGame();
        }
        //member methods
        public void DayOfGame()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Day" + i);
            }
        }
        public void Forecast()
        {

        }
        public void CustomersPurchaseLemonade(Player player, double pricePerCup, Weather weather) //use a switch case or if else like RPSLP
        {
            foreach(Customer customer in customers)
            {
                if (customer.BuyLemonade())
                {
                    player.wallet.Money += pricePerCup;
                }
            }
            if (weather.condition == "Cloudy")
            {
                //double customer /= 3 customer;
            }
        }
        //weather algorithm
    }
}
