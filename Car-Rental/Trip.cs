using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class Trip
    {

        // Key attribute
        public int Id
        {
            get;
            set;
        }

        public string Start
        {
            get;
            set;
        }

        public string Finish
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public int DayOfTrip
        {
            get;
            set;
        }

        public Vehicle Vehicle
        {
            get;
            set;
        }

        public Driver Driver
        {
            get;
            set;
        }

        public List<TripUser> Users
        {
            get;
            set;
        }

        public Trip(string start, string finish, DateTime date, int dayOfTrip, Vehicle vehicle, Driver driver, List<TripUser> users)
        {
            this.Start = start;
            this.Finish = finish;
            this.Date = date;
            this.DayOfTrip = dayOfTrip;
            this.Vehicle = vehicle;
            this.Driver = driver;
            this.Users = users;
        }

    }
}
