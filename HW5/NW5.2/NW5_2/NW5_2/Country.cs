using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class Country
    {
        private string countryName;

        public Country(string countryName)
        {
            this.countryName = countryName;
        }

        public string CountryName { get => countryName; set => countryName = value; }


        public void DisplayCountry()

        {

            Console.WriteLine("Country is " + countryName);

        }

    }
}
