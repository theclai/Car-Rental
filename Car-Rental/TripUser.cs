using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class TripUser
    {
        public User User
        {
            get;
            set;
        }

        public bool HasBaggage;

        public TripUser(User user, bool hasBaggage)
        {
            this.User = user;
            this.HasBaggage = hasBaggage;
        }

    }
}
