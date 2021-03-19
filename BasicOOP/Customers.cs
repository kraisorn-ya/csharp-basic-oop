using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP
{
    class Customers
    {
        private string _CustomerID;
        private string _CustomerName;
        private string _Address;

        public string CustomerID
        {
            get {
                return _CustomerID;
            }
            set {
                _CustomerID = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
            }
        }

        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
    }
}
