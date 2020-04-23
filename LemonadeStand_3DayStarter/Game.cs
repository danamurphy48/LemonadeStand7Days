using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        private Player player;
        private List<Day> days;
        private int currentDay;
        private Store store;

        //constructor
        public Game()
        {
            player = new Player();
            days = new List<Day>();
            currentDay = 1;
            store = new Store();
        }
        //member methods
        public void RunGame()
        {
            DisplayRules();
            PopulateDay();
            player.PickName();
            days.weather.DisplayWeather();
            DisplayForecast();
            GoToStore();
            //DisplayInventory(); have this in UserInterface?
            CraftRecipe();
            CraftPitcher();
            SellLemonade();
            DisplayEarnings();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("Over 7 days you will purchase supplies to make lemonade and set a price to sell it to customers.");
            Console.WriteLine("Customers will decide if they want to purchase your lemonade based on price and weather.");
            Console.WriteLine("If the price is over $1.00 no customers will buy lemonade regardless of the weather.");
            Console.WriteLine("If the weather is poor, then fewer customers will be interested purchasing lemonade.");
            Console.WriteLine("At the end of each day, you will see your gross and net income.");
        }
        public void PopulateDay()
        {
            Day day = new Day();
            days.Add("Day 1");
            days.Add("Day 2");
            days.Add("Day 3");
            days.Add("Day 4");
            days.Add("Day 5");
            days.Add("Day 6");
            days.Add("Day 7");
        }
        public void GoToStore()
        {
            Console.WriteLine("Please purchase ingredients and cups to start your lemonade stand.");
            Console.WriteLine("You currently have " + player.wallet);
            store.DisplayPrices();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
        }
        public void CraftRecipe()
        {
            player.recipe.AskRecipe();
        }
        public void CraftPitcher(Player player, Recipe recipe)
        {
            MakePitcher(player.recipe);
        }
        public void SellLemonade()
        {
            day.customer.PopulateCustomerNames();
            day[1].PopulateCustomers();
        }
        public void DisplayEarnings()
        {
            
        }
    }
}
