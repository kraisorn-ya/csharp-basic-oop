using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleDynamicTipe;
using System.Collections;

namespace BasicOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            Products<int> p1 = new Products<int>();
            p1.ProductID = "001";
            p1.ProductName = "พื้นฐาน Visual Basic";
            p1.ProductPrice = 345;

            Products<double> p2 = new Products<double>();
            p2.ProductID = "002";
            p2.ProductName = "พื้นฐาน Visual Basic";
            p2.ProductPrice = 379.5;
        }
    }
}
