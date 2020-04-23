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
        public int numberOfCustomers;
        private int conditionPreference;
        private int customerConditionPreference;
        private int temperaturePreference;
        private int customerTemperaturePreference;
        private int conditionMultiplier;
        private int temperatureMultiplier;
        public Player player;
        private Random random;

        //constructor
        public Day()
        {

            weather = new Weather();
            customers = new List<Customer>();

            numberOfCustomers = 100;
            PopulateCustomers();

            player = new Player();
            Random random = new Random();
        }
        //member methods
        public void PopulateCustomers()
        {
            for (int i = 0; i < numberOfCustomers; i++)
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
        public int FilterCustomerPreference(Weather weather, Customer customer) //could I do customer.SetConditions();
        {         
            Random random = new Random();
            int randomWeather = random.Next(0, 2);
            customer.conditionPreference = weather.condition[randomWeather];

            customer.buyingMultiplier = conditionMultiplier + temperatureMultiplier;
            
            //foreach(Customer customer in customers)
            //if(customer.buyingMultiplier >= 4)
            //{
            //   CustomersPurchaseLemonade(player, pricePerCup, pitcher, weather);
            //}

            if(weather.condition == "Sunny" && customer.conditionPreference.ToString() == "Sunny")
            {
                conditionMultiplier = 3;
            }
            else if(weather.condition == "Cloudy")
            {
                conditionMultiplier = 2;
            }
            else
            {
                conditionMultiplier = 1;
            }
            if (weather.condition == customer.conditionPreference.ToString())
            {
                conditionMultiplier = 3;
            }
            return conditionMultiplier + temperatureMultiplier;
        }
        public int FilterCustomersByTemperature(Weather weather, Customer customer)
        {
            Random random = new Random();
            int randomWeather = random.Next(55, 100);
            customer.temperaturePreference = randomWeather;

            if (weather.temperature <=59 && customer.temperaturePreference <=59)
            {
                temperatureMultiplier = 3;
            }
            else
            {
                temperatureMultiplier = 0;
                //return false;
            }
            if (weather.temperature <= 100 && customer.temperaturePreference <= 100)
            {
                temperatureMultiplier = 3;
            }
            else if (weather.temperature <=100 && customer.temperaturePreference >=75)
            {
                temperatureMultiplier = 2;
            }
            if (weather.temperature >=75 && customer.temperaturePreference < 75)
            {
                temperatureMultiplier = 0;
            }
            return temperatureMultiplier;
        }


        public void ChooseToBuy(Player player, double pricePerCup)
        {
            numberOfCustomers = 100;
            bool customerBuy = true;
            if (pricePerCup > 1.00)
            {
                numberOfCustomers -= 100;
                customerBuy = false;
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
        }
        public void CalculateCustomerDemand()
        {
            numberOfCustomers--;
        }
        public void CustomersPurchaseLemonade(Player player, double pricePerCup, Pitcher pitcher, Weather weather)
        {
            //Two paths you can take:
            //1. customers represents the filtered down customers who will buy (no need for conditional here, just have them buy)
            //2. customers represents all customers for the day. Only customers with member variable willBuy = true will actually buy lemonade
            // you can achieve this by if(buying >= 4) { customer willBuy = true} (you will need this in a loop to iterate over all customers
            foreach (Customer customer in customers)
            {
                customer.buyingMultiplier = conditionMultiplier + temperatureMultiplier;
                if (customer.buyingMultiplier >= 4)
                {
                    customer.BuyLemonade(player, pitcher, pricePerCup);
                }
                
                
            }
        }
    }
}
