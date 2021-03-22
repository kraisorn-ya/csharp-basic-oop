using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomA;
using Room.SubB;

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
            Customers myCustomer = new Customers("Kraisorn","Dungprasong");
            string result = "";
            result = "ฟิลด์ _FirstName : " + myCustomer.FirstName + Environment.NewLine;
            result += "ฟิลด์ _LastName : " + myCustomer.LastName;

            MessageBox.Show(result, "ผลการทำงาน");
        }
    }
}
