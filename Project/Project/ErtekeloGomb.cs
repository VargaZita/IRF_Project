using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class ErtekeloGomb: Button
    {
        private int csillagvalue;
        public int CsillagValue
        {
            get { return csillagvalue; }
            set
            {
                csillagvalue = value;
                if (csillagvalue < 1)
                    csillagvalue = 5;
                else if (csillagvalue > 5)
                    csillagvalue = 1;

                if (csillagvalue == 0)
                    Text = "";
                else
                    Text = csillagvalue.ToString();
            }
        }

        public ErtekeloGomb()
        {
            Height = 25;
            Width = Height;
            BackColor = Color.Yellow;
            CsillagValue = 0;
            MouseDown += ErtekeloGomb_MouseDown;
        }

        private void ErtekeloGomb_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                CsillagValue++;
            if (e.Button == MouseButtons.Right)
                CsillagValue--;
        }
    }
}
