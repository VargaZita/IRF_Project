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
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();

        public Form1()
        {
            InitializeComponent();

            context.Termekek.Load();

            //TermekListBox.DisplayMember = "Nev";
            
            TermékListázás();
        }

        private void TermékListázás()
        {
            var t = from x in context.Termekek
                    where x.Nev.Contains(TermekTextBox.Text)
                    select x;
            termekekBindingSource.DataSource = t.ToList();
        }

        private void TermekTextBox_TextChanged(object sender, EventArgs e)
        {
            TermékListázás();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
           
            
        }

        

        private void TermekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TermekInfo();
        }
        
        private void TermekInfo()
        {

            termekekBindingSource.DataSource = context.Termekek.Local ;
        }

        private void AdatMegjelenitesButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
