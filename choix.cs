using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class choix : Form
    {


        public choix()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" || maskedTextBox1.Text.Contains(" ") == true)
            {
                MessageBox.Show("Mot non valide");
            }
            else
            {
                String mot = maskedTextBox1.Text;
                this.Hide();
                multi multi = new multi(mot);
                multi.Show();
            }
        }

        private void choix_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
