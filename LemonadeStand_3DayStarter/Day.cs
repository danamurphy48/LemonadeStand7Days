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
        public void CreateCustomers(double pricePerCup)
        {

        }
        public void PopulateCustomers()
        {
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
        public void FilterCustomers()
        {

        }
        public void FilterCustomersByPrice(double pricePerCup)
        {
            int numberOfCustomers = 0;
            if (pricePerCup > 1.00)
            {
                numberOfCustomers = 30;
                
            }
            else if (pricePerCup <= 1.00)
            {
                numberOfCustomers = 50;
            }
            
        }
        public void FilterCustomersByWeatherCondition()
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
