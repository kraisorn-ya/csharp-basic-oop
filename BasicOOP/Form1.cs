using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Customers c = new Customers();
            c.CustomerID = "123";
            c.CustomerName = "Kraisorn Dunprapsong";
            c.Address = "45 SaDao";

            lbID.Text = c.CustomerID;
            lb_FullName.Text = c.CustomerName;
            lbAddress.Text = c.Address;

        }
    }
}
