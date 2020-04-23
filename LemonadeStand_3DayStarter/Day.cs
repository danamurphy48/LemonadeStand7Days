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
        private int conditionPreference;
        private int customerConditionPreference;
        private int temperaturePreference;
        private int customerTemperaturePreference;
        private int conditionMultiplier;
        private int temperatureMultiplier;
        public Player player;
        //private int currentCustomerCount;
        //private int maximumCustomerCount;
        Random random = new Random();

        //constructor
        public Day()
        {
            //DisplayCurrentWeather();
            weather = new Weather();
            customers = new List<Customer>();
            //dayOfGame = new List<int>();
            DayOfGame();
            numberOfCustomers = 100;
            player = new Player();

        }
        //member methods
        public void DayOfGame()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Day " + i);

            }
        }

        //public void CreateCustomers(double pricePerCup)
        //{

        //}
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
            if(customer.buyingMultiplier >= 4)
            {
                customer.BuyLemonade(Player player; Pitcher pitcher; double pricePerCup);
            }

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
            return conditionMultiplier + temperatureMultiplier;
        }
        public int FilterCustomersByTemperature(Weather weather, Customer customer) //tweak numbers for this
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


        public void ChooseToBuy(Player player, double pricePerCup) //make variables of pricing, temp, and condition? to control customer flow
        {//while loop? should this be public void?
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
        //public void FilterCustomersByPrice(double pricePerCup)
        //{
        //    int numberOfCustomers = 0;
        //    if (pricePerCup > 1.00)
        //    {
        //        numberOfCustomers = 30;
                
        //    }
        //    else if (pricePerCup <= 1.00)
        //    {
        //        numberOfCustomers = 50;
        //    }
            
        //}
        //public void FilterCustomersByWeatherCondition(Weather weather) //make a bool?  Fix
        //{
        //    int numberOfCustomers = 100;
        //    int currentCustomerCount;
        //    int maximumCustomerCount;
        //    if (weather.condition == "Sunny")
        //    {
        //        maximumCustomerCount = 100;
        //        currentCustomerCount = 100;
        //        numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;

        //    }
        //    else if (weather.condition == "Cloudy")
        //    {
        //        maximumCustomerCount = 100;
        //        currentCustomerCount = 75;
        //        numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;
        //    }
        //    else if (weather.condition == "Rainy")
        //    {
        //        maximumCustomerCount = 100;
        //        currentCustomerCount = 50;
        //        numberOfCustomers = (currentCustomerCount / maximumCustomerCount) * 100;
        //    }
        //}
        //public void FilterCustomersByWeatherTemperature(Weather weather, int numberOfCustomers)//from weather condition filter
        //{
        //    if (weather.temperature <= 59) //want 40% of above customer count
        //    {
                
        //        currentCustomerCount = (numberOfCustomers / maximumCustomerCount);
                
        //    }
        //}