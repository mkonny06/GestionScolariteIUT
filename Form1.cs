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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBxlogin.Text.ToString() == "admin" && TBxpwd.Text.ToString() == "admin")
            {
                Page_d_accueil Page_d_accueil = new Page_d_accueil();
                this.Hide();
                Page_d_accueil.Show();
            }
            else
                MessageBox.Show("parametre de connexion incorrectes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TBxpwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
