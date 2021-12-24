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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            solo solo = new solo();
            solo.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            choix choix = new choix();
            choix.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le Jeu Du Pendu\nCodé par Gatien GILLOT\nLanguage utilisé : C#\nCode du logiciel disponible sur mon Github : @GatienFrenchDev\nContact : contact@gatiendev.tk", "Jeu Du Pendu | A Propos");
        }
    }
}
