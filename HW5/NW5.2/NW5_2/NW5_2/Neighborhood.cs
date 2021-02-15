using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class Neighborhood : City
    {


        private string nBName;
        private string streetName;
        private int houseNumber;

        public Neighborhood(string nBName, string streetName, int houseNumber, string cityName, string districtName, string countryName) : base (cityName, districtName, countryName)
        {
            this.NBName = nBName;
            this.streetName = streetName;
            this.houseNumber = houseNumber;
        }

        public string NBName { get => nBName; set => nBName = value; }
        public string StreetName { get => streetName; set => streetName = value; }
        public int HouseNumber { get => houseNumber; set => houseNumber = value; }

        public void DisplayNeighborhood()

        {

            Console.WriteLine("Neighborhood is " + nBName);
            Console.WriteLine("Street is " + streetName);
            Console.WriteLine("Number of House is " + houseNumber);


        }


    }
}
