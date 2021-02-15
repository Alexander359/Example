using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_2
{
    class District : Country
    {
        private string districtName;

        public District(string districtName, string countryName) : base (countryName)
        {
            this.districtName = districtName;
        }

        public string DistrictName { get => districtName; set => districtName = value; }


        public void DisplayDistrict()

        {

            Console.WriteLine("District is " + districtName);

        }
    }
}
