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
        int[] arr = { 10,100,20,200,3,40,5,50};
        string str = "";

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

        private void button1_Click(object sender, EventArgs e)
        {
            str = "";
            for (int i = 0; i < arr.Length; i++)
            { 
                str = str + arr[i] + " ";
            }
            str = str + Environment.NewLine
                    + "------------------"
                    + Environment.NewLine;
            int max = arr[0];
            for (int j = 1; j < arr.Length; j ++)
            {
                if (max <arr[j])
                {
                    max = arr[j];
                }
            }
            str = str + max.ToString();
            MessageBox.Show(str, "result Max");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str = str + arr[i] + " ";
            }
            str = str + Environment.NewLine
                    + "------------------"
                    + Environment.NewLine;
            int min = arr[0];
            for (int j = 1; j < arr.Length; j++)
            {
                if (min > arr[j])
                {
                    min = arr[j];
                }
            }
            str = str + min.ToString();
            MessageBox.Show(str, "result Max");
        }
    }
}
