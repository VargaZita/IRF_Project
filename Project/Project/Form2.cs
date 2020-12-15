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
using System.Windows.Forms.DataVisualization.Charting;

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
            ShowOnChart();

        }

        private void TermekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ShowOnChart();
            
            
        }

        private void ShowOnChart()
        {
            
            var ValasztottTermek = from x in context.Ertekelesek
                                   where x.TermekFK == ((Termekek)TermekListBox.SelectedItem).TermekID
                                   select x;


            int darabszam = ValasztottTermek.Count();
            if (darabszam==0)
            {
                panel1.Visible = true;
                label1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
                label1.Visible = false;
            }
            var ertekelesszam = from x in ValasztottTermek
                                group x by new { x.Csillag } into g
                                select new ErtekelesSzam()
                                {
                                    CsillagSzam = g.Key.Csillag.ToString(),
                                    Mennyiseg = (from x in g select x).Count()
                                };

            ShowMegjegyzes(ValasztottTermek);

            GetÖsszegÉsÁtlag(ValasztottTermek);

            ertekelesSzamBindingSource.DataSource = ertekelesszam.ToList();
            chart1.DataBind();
        }

        private void ShowMegjegyzes(IQueryable<Ertekelesek> ValasztottTermek)
        {

            var megjegyzes = (from x in ValasztottTermek
                              where x.Megjegyzesek != null
                              select x.Megjegyzesek).FirstOrDefault();
            if (megjegyzes==null)
            {
                textBox1.Text = "Ehhez a termékhez még nem fűztek megjegyzést. Legyél Te az első!";
            }
            else
            {
                textBox1.Text = megjegyzes.ToString();
                textBox1.Enabled = false;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            

            if (textBox1.Text == "")
            {

                textBox1.Text = "Ehhez a termékhez még nem fűztek megjegyzést. Legyél Te az első!";

            }
        }

        private void GetÖsszegÉsÁtlag(IQueryable<Ertekelesek> ValasztottTermek)
        {
            var egycsillag = (from x in ValasztottTermek
                              where x.Csillag == 1
                              select x).Count();
            var ketcsillag = (from x in ValasztottTermek
                              where x.Csillag == 2
                              select x).Count();
            var haromcsillag = (from x in ValasztottTermek
                                where x.Csillag == 3
                                select x).Count();
            var negycsillag = (from x in ValasztottTermek
                               where x.Csillag == 4
                               select x).Count();
            var otcsillag = (from x in ValasztottTermek
                             where x.Csillag == 5
                             select x).Count();

            double szorzat = 1 * egycsillag + 2 * ketcsillag + 3 * haromcsillag + 4 * negycsillag + 5 * otcsillag;


            double ossz = (from x in ValasztottTermek
                        select x).Count();

            if (ossz>0)
            {
                double atlag = szorzat / ossz;

                double kerekatlag = Math.Round(atlag, 2);

                osszesentextbox.Text = ossz.ToString();
                atlagtextbox.Text = kerekatlag.ToString();
            }
            else
            {
                osszesentextbox.Text = ossz.ToString();
                atlagtextbox.Text = 0.ToString();

            }

        }
    }
}
