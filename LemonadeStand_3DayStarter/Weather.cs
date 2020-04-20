using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        //member variables (HAS A)
        public string condition;
        public int temperature;
        private List<string> weatherConditions;
        public Random random = new Random();

        //constructor (SPAWNER)
        public Weather()
        {
            weatherConditions = new List<string>();
            PopulateWeatherConditions();
            SetCondition();
            SetTemperature();
        }
        //member methods (CAN DO)
        public void DisplayCurrentWeather()
        {
            Console.WriteLine($"{condition} & {temperature}");
            //Console.WriteLine(condition + " " + temperature);
        }

        //private void DisplayWeatherConditions(List<string> weatherConditions) //don't need
        //{
        //    foreach (string weatherCondition in weatherConditions)
        //    {
        //        Console.WriteLine(weatherCondition);
        //    }
        //}
        private void PopulateWeatherConditions()
        {
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Rainy");
        }
        private void SetTemperature()
        {
            temperature = random.Next(55,100);
        }
        private void SetCondition()
        {
            int randomNumber = random.Next(0, 2);
            condition = weatherConditions[randomNumber];
        }

    }
}
