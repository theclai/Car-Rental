using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    class User
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

        public string Document
        {
            get;
            set;
        }

        public User(string name, string document)
        {
            this.Name = name;
            this.Document = document;
        }

    }
}
