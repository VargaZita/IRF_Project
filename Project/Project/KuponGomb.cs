using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class KuponGomb: Button
    {
        private int kuponszam;
        public int KuponSzam
        {
            get { return kuponszam; }
            set
            {
                kuponszam = value;
               
            }
        }

        public KuponGomb()
        {
            Height = 50;
            Width = 130;
            BackColor = Color.AliceBlue;
            Text = "Lássuk a kedvezményt";

            

            Click += KuponGomb_Click;
        }

        private void KuponGomb_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            KuponSzam = rnd.Next(0, 9);
        }
    }
}
