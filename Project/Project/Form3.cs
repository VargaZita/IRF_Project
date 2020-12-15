using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        Database1Entities context = new Database1Entities();
        public Form3()
        {
            InitializeComponent();

            context.Termekek.Load();
            context.Arak.Load();
            context.Boltok.Load();

            termekekBindingSource.DataSource = context.Termekek.Local;
            boltokBindingSource.DataSource = context.Boltok.Local;

            TermékListázás();
            ÁrListázás();
        }

        private void TermékListázás()
        {
            var t = from x in context.Termekek
                    where x.Nev.Contains(TermekTextBox.Text)
                    select x;
            TermekListBox.DataSource = t.ToList();
            TermekListBox.DisplayMember = "Nev";


            
        }

        private void TermekTextBox_TextChanged(object sender, EventArgs e)
        {
            TermékListázás();
        }

        private void TermekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ÁrListázás();
        }

        private void ÁrListázás()
        {
            var termekvalaszto = from x in context.Arak
                                 where x.TermekFK == ((Termekek)TermekListBox.SelectedItem).TermekID
                                 select x;

            arakBindingSource.DataSource = termekvalaszto.ToList();
        }

        private void uRLTextBox_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(uRLTextBox.Text);
        }

        private void KedvezmenyButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            KedvezmenyButton.Visible = false;

            char[] lettersnumbers = "qwertzuiopasdfghjklyxcvbnm1234567890".ToCharArray();
            Random rnd = new Random();
            string kuponkod="";
            int kedvezmeny = rnd.Next(0, 49);
            KedvezmenyszazalekTextBox.Text = kedvezmeny.ToString();
            for (int i = 0; i < 6; i++)
            {
                kuponkod += lettersnumbers[rnd.Next(0, 35)].ToString();
            }
            KedvezmenykodTextBox.Text = kuponkod;
        }
    }
}
