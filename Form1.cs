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
    public partial class Form1 : Form
    {
        internal static GestionV gestV = new GestionV();
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutV f = new FormAjoutV();
            f.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listerVoituresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListageV f = new FormListageV();
            f.ShowDialog();
        }

        private void rechercherVoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecherche f = new FormRecherche();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
