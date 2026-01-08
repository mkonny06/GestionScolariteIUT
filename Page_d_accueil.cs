using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionScolariteIUT
{
    public partial class Page_d_accueil : Form
    {
        public Page_d_accueil()
        {
            InitializeComponent();
        }

        private void cycleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Page_d_accueil_Load(object sender, EventArgs e)
        {
            FicheEtudiant FicheEtudiant = new FicheEtudiant();
            panel1.Controls.Clear();
            panel1.Controls.Add(FicheEtudiant);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void gestionDesComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionDesComptes gestionDesComptes = new gestionDesComptes();
            panel1.Controls.Clear();
            panel1.Controls.Add(gestionDesComptes);

        }

        private void déconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            this.Hide();
            Form1.Show();
        }

        private void gestionDesEtudiantsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void actionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
