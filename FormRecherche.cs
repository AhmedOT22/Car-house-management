using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGrA
{
    public partial class FormRecherche : Form
    {
        public FormRecherche()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string matricule = textBox1.Text;
            Voiture v=Form1.gestV.RechercheVoiture(matricule);
            if (v == null)
            {
                MessageBox.Show("Le matricule n'existe pas!!");
                return;
            }
            textBox2.Text = v.Marque;
            textBox3.Text = v.Modele;
            textBox4.Text = v.DateMC.ToShortDateString();
            textBox5.Text = v.Prix.ToString();
            if (v.Carburant == TypeCarburant.Diesel)
                radioButton1.Checked = true;
            if (v.Carburant == TypeCarburant.Essence)
                radioButton2.Checked = true;
            if (v.Carburant == TypeCarburant.Hybride)
                radioButton3.Checked = true;
            if (v.Carburant == TypeCarburant.Electrique)
                radioButton4.Checked = true;
            
            if (v.Details.IndexOf(Accessoires.Climatisation)!=-1)
                checkBox1.Checked = true;
            if (v.Details.IndexOf(Accessoires.FermetureCentralisée) != -1)
                checkBox2.Checked = true;
            if (v.Details.IndexOf(Accessoires.CaméraRecul) != -1)
                checkBox3.Checked = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez vous vraiment supprimer cette voiture?","Alerte",MessageBoxButtons.OKCancel);
            if(res==DialogResult.OK)
                Form1.gestV.SupprimerVoiture(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voiture v = new Voiture();
            v.Matricule = textBox1.Text;
            v.Marque = textBox2.Text;
            v.Modele = textBox3.Text;
            v.DateMC = DateTime.Parse(textBox4.Text);
            v.Prix = double.Parse(textBox5.Text);
            if (radioButton1.Checked == true)
                v.Carburant = TypeCarburant.Diesel;
            if (radioButton2.Checked == true)
                v.Carburant = TypeCarburant.Essence;
            if (radioButton3.Checked == true)
                v.Carburant = TypeCarburant.Hybride;
            if (radioButton4.Checked == true)
                v.Carburant = TypeCarburant.Electrique;
            if (checkBox1.Checked == true)
                v.Details.Add(Accessoires.Climatisation);
            if (checkBox2.Checked == true)
                v.Details.Add(Accessoires.FermetureCentralisée);
            if (checkBox3.Checked == true)
                v.Details.Add(Accessoires.CaméraRecul);
            
            Form1.gestV.ModifierVoiture(textBox1.Text, v);
        }
    }
}
