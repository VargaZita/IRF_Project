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
    public partial class Form2 : Form
    {
        Database1Entities context = new Database1Entities();
        public Form2()
        {
            InitializeComponent();

            context.Termekek.Load();
            context.Ertekelesek.Load();

            termekekBindingSource.DataSource = context.Termekek.Local;


            ÉrtékelésListázás();
            TermékListázás();
        }

        
        private void ÉrtékelésListázás()
        {
           
            var ertekelesek = from x in context.Ertekelesek
                            select x;
                            
            ertekelesekBindingSource.DataSource = ertekelesek.ToList();
        }

        private void TermékListázás()
        {
            var t = from x in context.Termekek
                    where x.Nev.Contains(TermekNevTextBox.Text)
                    select x;
            TermekListBox.DataSource = t.ToList();
            TermekListBox.DisplayMember = "Nev";
        }

        private void TermekNevTextBox_TextChanged(object sender, EventArgs e)
        {
            TermékListázás();
        }

        private void ErtekelesAddButton_Click(object sender, EventArgs e)
        {
            Ertekelesek ertplusz = new Ertekelesek();
            ertplusz.TermekFK = ((Termekek)TermekListBox.SelectedItem).TermekID;
            ertplusz.Csillag = ertekeloGomb1.CsillagValue;
            ertplusz.Megjegyzesek = MegjegyzesTextBox.Text;

            context.Ertekelesek.Add(ertplusz);
            context.SaveChanges();
            ÉrtékelésListázás();
        }
    }
}
