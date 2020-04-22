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
        public int numberOfCustomers; //necessary or can I take out of customers List?
        private int currentCustomerCount;
        private int maximumCustomerCount;

        //constructor
        public Day()
        {
            //DisplayCurrentWeather();
            weather = new Weather();
            customers = new List<Customer>();
            //dayOfGame = new List<int>();
            DayOfGame();
            numberOfCustomers = 100;
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
            //int currentCustomerCount;
            //int maximumCustomerCount;
            //numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;    //seems unnecessary
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
        public void FilterCustomersByWeatherCondition(Weather weather) //make a bool?  Fix
        {
            int numberOfCustomers = 100;
            int currentCustomerCount;
            int maximumCustomerCount;
            if (weather.condition == "Sunny")
            {
                maximumCustomerCount = 100;
                currentCustomerCount = 100;
                numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;

            }
            else if (weather.condition == "Cloudy")
            {
                maximumCustomerCount = 100;
                currentCustomerCount = 75;
                numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;
            }
            else if (weather.condition == "Rainy")
            {
                maximumCustomerCount = 100;
                currentCustomerCount = 50;
                numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;
            }
        }
        public void FilterCustomersByWeatherTemperature(Weather weather, int numberOfCustomers)//from weather condition filter
        {
            if (weather.temperature <= 59) //want 40% of above customer count
            {
                
                currentCustomerCount = (numberOfCustomers / maximumCustomerCount);
                
            }
        }
        public bool ChooseToBuy(Player player, double pricePerCup, Weather weather) //make variables of pricing, temp, and condition? to control customer flow
        {//while loop? should this be public void?
            int numberOfCustomers = 100;
            bool customerBuy = true;
            if (pricePerCup > 1.00)
            {
                numberOfCustomers -= 100;
            }
            else if (pricePerCup <= 1.00)
            {
                numberOfCustomers -= 95;
            }
            else if (pricePerCup <= .90)
            {
                numberOfCustomers -= 90;
            }
            else if (pricePerCup <= .80)
            {
                numberOfCustomers -= 75;
            }
            else if (pricePerCup <= .70)
            {
                numberOfCustomers -= 50;
            }
            else if (pricePerCup <= .60)
            {
                numberOfCustomers -= 25;
            }
            else if (pricePerCup <= .50)
            {
                numberOfCustomers = 100;
            }
            return true;
        }
        public void CustomersPurchaseLemonade(Player player, double pricePerCup, Pitcher pitcher, Weather weather) //use a switch case or if else like RPSLP
        {
            foreach(Customer customer in customers)
            {
                if (customer.BuyLemonade())
                {
                    player.wallet.Money += pricePerCup;
                    pitcher.cupsLeftInPitcher--; //or does this need to be -- to cup inventory
                }
            }
            //if (weather.condition == "Cloudy")
            //{
            //    //double customer /= 3 customer;
            //}
        }
        //weather algorithm
    }
}
