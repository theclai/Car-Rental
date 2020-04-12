using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    public class Driver
    {
        // Key attribute
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        // Unique attribute
        public string License
        {
            get;
            set;
        }

        public Driver(string name, string license)
        {
            this.Name = name;
            this.License = license;
        }

    }
}
