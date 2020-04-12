using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Vehicle
    {
        // Key attribute
        public int Id
        {
            get;
            set;
        }

        public string Brand
        {
            get;
            set;
        }

        public int BuiltYear
        {
            get;
            set;
        }

        public Vehicle(string brand, int builtYear)
        {
            this.Brand = brand;
            this.BuiltYear = builtYear;
        }

    }
}
