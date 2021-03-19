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
            Products p = new Products();
            String result = p.ProductID + Environment.NewLine +
                              p.ProductName + Environment.NewLine +
                              p.ProductPrice.ToString();

            MessageBox.Show(result, "ข้อมูลลูกค้า");

        }
    }
}
