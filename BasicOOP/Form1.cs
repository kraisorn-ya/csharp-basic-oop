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
using AbstractClass;

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
            double result = 0.0;
            Calculator c = new Calculator();
            result = c.Add(5,10);
            MessageBox.Show(result.ToString(), "ผลบวก");

            result = c.Subtract(10, 3);
            MessageBox.Show(result.ToString(), "ผลลบ");

            result = c.Multiply(2, 3);
            MessageBox.Show(result.ToString(), "ผลคูณ");

            result = c.Divide(4, 2);
            MessageBox.Show(result.ToString(), "ผลหาร");
        }
    }
}
