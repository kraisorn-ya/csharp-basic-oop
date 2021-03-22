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
            absProgrammer p = default(absProgrammer);
            p = new Programmer();
            p.Programming();

            p = new SA();
            p.Programming();
        }
    }
}
