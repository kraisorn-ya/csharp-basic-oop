using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AbstractClass
{
    public class Calculator : absCalculator
    {
        public override double Add(double x, double y)
        {
            return (x + y);
        }

        public override double Subtract(double x, double y)
        {
            return (x - y);
        }

        public override double Multiply(double x, double y)
        {
            MessageBox.Show("คูณตัวเลขเสร็จแล้ว");
            return (x * y);
        }
    }
}
