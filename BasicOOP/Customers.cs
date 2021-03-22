using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOOP
{
    class Customers
    {
        string _FirstName;
        string _LastName;
        public Customers() // การสร้างออบเจ็กต์ Customer ขึ้นจากคลาสต้น Customers โดยไม่มีการส่งค่ากับ Constructor
        { 
        }

        public Customers(string FirstName, string LastName) // สร้างออบเจ็กต์ Customer ขึ้นมาจากคลาสต้นแบบ Customer โดยมีการส่งค่า Parameter ให้กับ Constructor
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
