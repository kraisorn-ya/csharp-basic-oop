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
            Queue<string> q = new Queue<string>();
            q.Enqueue("1.Visual C#");
            q.Enqueue("2.Visual Basic");
            q.Enqueue("3.Swift");
            q.Enqueue("4.JAVA");
            q.Enqueue("5.HTML5");

            string stritems = ShowData(q);
            MessageBox.Show(stritems, "ข้อมูลใน Queue");

            q.Peek();
            stritems = ShowData(q);
            MessageBox.Show(stritems," ข้อมูลใน Queue หลังจาก Peek");

            q.Dequeue();
            stritems = ShowData(q);
            MessageBox.Show(stritems, " ข้อมูลใน Queue หลังจาก Dequeue");
        }

        public string ShowData(IEnumerable ie)
        {
            string str = "";
            IEnumerator item = ie.GetEnumerator();

            while (item.MoveNext())
            {
                str = str + item.Current.ToString() + Environment.NewLine;
            }
            return str;
        }
    }
}
