using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP
{
    class Customers
    {
        public string _FullName;
        public int _Salary;


        public string FullName
        {
            get {
                return _FullName;
            }
            set {
                _FullName = value;
            }
        }

        public int Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                _Salary = value;
            }
        }
    }
    
}
