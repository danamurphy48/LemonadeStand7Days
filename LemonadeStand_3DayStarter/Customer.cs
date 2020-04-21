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
        public Customer()
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
            //for (int i = 0; i < 100; i++) //can you just add names like customer1++
            //{
            //    name = {$"{"customer"} + {i}"};
            //    names.Add(name);
            //}
        }
        public bool BuyLemonade()
        {
            return true;

        }
        public bool ChooseToBuy(Player player, double pricePerCup, Weather weather) //make variables of pricing, temp, and condition? to control customer flow
        {//while loop?
            int numberOfCustomers = 100;
            bool customerBuy = true;
            if (pricePerCup > 1.00)
            {
                numberOfCustomers -= 100;
                return false;//????????
            }
            else if (pricePerCup <= 1.00)
            {
                numberOfCustomers -= 95;
                return true;
            }
            else if (pricePerCup <= .90)
            {
                numberOfCustomers -= 90;
                return true;
            }
            else if (pricePerCup <= 80)
            {
                numberOfCustomers -= 75;
            }
            else if (pricePerCup >= .50 && (weather.temperature <= 59 && (weather.condition == "Cloudy")))
            {
                result = numberOfCustomers * (pricePerCup.bracketPricePerCup) * (weather.temperature.bracketTemperature) * (weather.condition.bracketWeatherCondition);
                return false;
            }
            return true;
        }
        //public void Junk()
        //{
        //    foreach (Customer customer in customers) //only want 1/4 of customers to purchase at conditions below
        //    {
        //        if (weather.temperature <= 59 && priceOfCup >= 0.25)
        //        {
        //            customer.BuyLemonade(); //customer.BuyLemonade() = false; or return false? or like 1/4 customers purchase
        //            player.wallet.Money += priceOfCup;
        //        }
        //    }
        //    foreach (Customer customer in customers)
        //    {
        //        if (weather.temperature > 60 && weather.temperature <= 69 && priceOfCup >= 0.30)
        //        {
        //            customer.BuyLemonade();
        //            player.wallet.Money += priceOfCup;
        //        }
        //    }
        //}
    }
}
