using System;
using HW5_2;

namespace NW5_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Neighborhood N1 = new Neighborhood("Smirnoff", "WallStreet", 33, "New York", "New York", "USA");
            Neighborhood N2 = new Neighborhood("Petroff", "East River", 41, "New York", "New York", "USA");
            Neighborhood N3 = new Neighborhood("Sidoroff", "Broadway", 24, "New York", "New York", "USA");

            N1.DisplayCountry();
            N1.DisplayDistrict();
            N1.DisplayCity();
            N1.DisplayNeighborhood();

            Console.WriteLine("====================================================");


            N2.DisplayCountry();
            N2.DisplayDistrict();
            N2.DisplayCity();
            N2.DisplayNeighborhood();

            Console.WriteLine("====================================================");

            N3.DisplayCountry();
            N3.DisplayDistrict();
            N3.DisplayCity();
            N3.DisplayNeighborhood();

            
            Console.ReadLine();
        }
    }
}
