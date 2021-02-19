using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Voorbeeld_ToString_en_Equals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList arrListGebruikers = new ArrayList();
        List<Gebruiker> listGebruikers = new List<Gebruiker>();


        private void cmbType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbStudieToelage.Visible = false;
            lblLoon.Visible = false;
            txtLoon.Visible = false;
            switch (cmbType.SelectedItem.ToString())
            {
                case "D":
                    lblLoon.Visible = true;
                    txtLoon.Visible = true;
                    break;
                case "S":
                    cbStudieToelage.Visible = true;
                    break;
            }
        }

        private void btnToevoegen_Click_1(object sender, EventArgs e)
        {
            int nr;
            if (int.TryParse(txtNummer.Text, out nr))
            {

                switch (cmbType.SelectedItem.ToString())
                {
                    case "G":
                        Gebruiker g = new Gebruiker(char.Parse(cmbType.SelectedItem.ToString()), nr, txtVoornaam.Text, txtAchternaam.Text);
                        arrListGebruikers.Add(g);
                        listGebruikers.Add(g);
                        lblResult.Text = g.ToonAlles("-");
                        break;
                    case "D":
                        double loon;
                        if (double.TryParse(txtLoon.Text, out loon))
                        {
                            Docent d = new Docent(char.Parse(cmbType.SelectedItem.ToString()), nr, txtVoornaam.Text, txtAchternaam.Text, loon);
                            arrListGebruikers.Add(d);
                            listGebruikers.Add(d);
                            lblResult.Text = d.ToonAlles("-");
                        }
                        else
                        {
                            MessageBox.Show("Loon is niet numeriek.");
                        }
                        break;
                    case "S":
                        Student s = new Student(char.Parse(cmbType.SelectedItem.ToString()), nr, txtVoornaam.Text, txtAchternaam.Text, cbStudieToelage.Checked);
                        arrListGebruikers.Add(s);
                        listGebruikers.Add(s);
                        lblResult.Text = s.ToonAlles("-");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nummer is niet numeriek.");
            }
        }
        private void btnPolymorfisme_Click_1(object sender, EventArgs e)
        {
            Docent d1 = new Docent('D', 1, "Hans", "Van Soom", 1000);
            lblResult.Text = d1.ToonAlles("-");

            Gebruiker d2 = new Docent('D', 1, "Hans", "Van Soom", 1000); //ok: Docent is ook een Gebruiker
            lblResult.Text += d2.ToonAlles("*");

            //Docent d3 = new Gebruiker('D', 3, "H", "VS", 1000);
            //nok: een Gebruiker is niet persé een docent, kan ook student zijn

            //Docent d4= d2; // nok: een Gebruiker object kan niet zomaar omgevormd worden tot een Docent, expliciet cast nodig
            Docent test = (Docent)d2;
            lblResult.Text += test.ToonAlles("/");
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            Gebruiker g1 = new Gebruiker('G', 10, "Peter", "Peeters");
            lblResult.Text = g1.ToonAlles("-");
            Gebruiker g2 = new Gebruiker('G', 20, "Peter", "Peeters");
            lblResult.Text += g2.ToonAlles("*");

            if (g1.Equals(g2))
            {
                lblResult.Text += "Objecten zijn  hetzelfde." + Environment.NewLine;
            }
            else
            {

                lblResult.Text += "Objecten zijn verschillend." + Environment.NewLine;
            }

            lblResult.Text += "----------------------------------" + Environment.NewLine;
            Gebruiker g3 = new Gebruiker('G', 10, "Peter", "Peeters");
            lblResult.Text += g1.ToonAlles("*");
            lblResult.Text += g3.ToonAlles("*");
            if (g1.Equals(g3))
            {
                lblResult.Text += "Objecten zijn  hetzelfde.";
            }
            else
            {

                lblResult.Text += "Objecten zijn verschillend.";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cmbType.Items.Add("G");
            cmbType.Items.Add("D");
            cmbType.Items.Add("S");
            cmbType.SelectedIndex = 0;
        }


        private void btnToonAlles_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            foreach (Gebruiker g in arrListGebruikers)
            {
                lblResult.Text += g.ToString();
            }
        }












        //Onderstaande is niet relevant, er is ergens iets misgelopen met het copy pasten.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {


        }
        private void btnPolymorfisme_Click(object sender, EventArgs e)
        {

        }



    }
}
