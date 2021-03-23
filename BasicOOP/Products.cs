using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP
{
    class Products<T>
    {
        private string _ProductID;
        private string _ProductName;

        private T _ProductPrice;
        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        public T ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }

    }
}
