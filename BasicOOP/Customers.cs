using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP
{
    class Customers
    {
        string _FirstName;
        string _LastName;
        public Customers()
        { 
        }
        public Customers(string FirstName, string LastName)
        {
            this._FirstName = FirstName;
            this._LastName = LastName;
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
    }
}
