using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
namespace AbstractClass
{
    public abstract class absCalculator
    {
        public abstract double Add(double x, double y);
        public abstract double Subtract(double x, double y);

        public virtual double Multiply(double x, double y)
        {
            return (x * y);
        }
        public double Divide(double x, double y)
        {
            return (x / y);
        }
    }
}
