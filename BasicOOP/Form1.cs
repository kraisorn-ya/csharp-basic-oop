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
            c.FullName = "Kraisorn dungprasong";
            c.Salary = 10000;
            MessageBox.Show("Type ของออบเจ็กต์ c : " + c.GetType().ToString());

            var a = new { FullName = "Kraisorn Dungprasong", Salary = 10000 };
            MessageBox.Show("Type ของออบเจ็กต์ a : "+ a.GetType().ToString());

            var f = a.FullName;
            var s = a.Salary;
            MessageBox.Show("ชื่อ-สกุล : " + f + "เงินเดือน : " + s.ToString());
        }
    }
}
