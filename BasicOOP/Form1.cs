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
            Products p1 = new Products();
            p1.ProductID = "001";
            p1.ProductName = "คู่มือ Visual C# 2015";
            p1.ProductsSerialNumber = new SerialNumber
            {
                FirstString = "aaa",
                LastNumber = 999
            };

            string str1 = "สินค้า :" + p1.ProductID + " " + p1.ProductID + Environment.NewLine +
                "serial Number" + p1.ProductsSerialNumber.FirstString + "-" + p1.ProductsSerialNumber.LastNumber;
            MessageBox.Show(str1, "สินค้าชิ้นที่ 1 (str1)");
        }
    }
}
