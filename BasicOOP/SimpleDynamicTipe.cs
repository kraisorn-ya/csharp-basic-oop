using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimpleDynamicTipe
{
    public abstract class absProgrammer
    {
        public abstract void Programming();
    }

    public class Programmer : absProgrammer
    {
        public override void Programming()
        {
            MessageBox.Show("Programmer เขียนโปรแกรมได้");
        }
    }

    public class SA : absProgrammer
    {
        public override void Programming()
        {
            MessageBox.Show("SA เขียนโปรแกรมได้");
        }
    }
}
