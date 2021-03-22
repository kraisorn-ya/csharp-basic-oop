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
            int[] arr = { 1, 2, 3, 4, 2, 3, 4, 5 };
            string str = "";

            for (int i=0; i < arr.Length; i++)
            {
                str = str + arr[i] + " ";
            }

            str = str + Environment.NewLine
            + "----------------------------"
            + Environment.NewLine;

            int[] arrDis = arr.Distinct().ToArray();
            for (int i = 0; i < arrDis.Length; i++)
            {
                str = str + arrDis[i] + " ";
            }

            MessageBox.Show(str, "result");
        }
    }
}
