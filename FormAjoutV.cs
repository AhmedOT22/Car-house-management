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
    public partial class FormAjoutV : Form
    {
        List<string> marques = new List<string>() { "Audi", "Ford", "Kia" };
        Dictionary<string, List<string>> modeles = new Dictionary<string, List<string>>();
        public FormAjoutV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            radioButton1.Checked = true;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = false;
            comboBox1.Text = comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Voiture v = new Voiture();
            v.Matricule = textBox1.Text;
            v.Marque = comboBox1.Text;
            v.Modele = comboBox2.Text;
            v.DateMC = dateTimePicker1.Value;
            v.Prix =double.Parse(textBox2.Text);
            
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

            Form1.gestV.AjouterVoiture(v);//ajout de la voiture
            MessageBox.Show("voiture ajoutée avec succès");
        }

        private void FormAjoutV_Load(object sender, EventArgs e)
        {

            modeles["Audi"] = new List<string>() { "A4", "A6", "Q5", "Q7" };
            modeles["Ford"] = new List<string>() { "Fiesta", "Kuga", "CMax"};
            modeles["Kia"] = new List<string>() { "Sorento", "sportage"};
            comboBox1.DataSource = marques;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string marque = comboBox1.SelectedItem.ToString();
            List<string> l = modeles[marque];
            comboBox2.DataSource = l;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
