using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class City : District
    {
        private string cityName;

        public City(string cityName, string districtName, string countryName) : base (districtName, countryName)
        {
            this.cityName = cityName;
        }

        public string CityName { get => cityName; set => cityName = value; }

        public void DisplayCity()

        {

            Console.WriteLine("City is " + cityName);

        }


    }
}
