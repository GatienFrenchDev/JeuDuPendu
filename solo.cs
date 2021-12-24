using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JeuDuPendu
{
    public partial class solo : Form
    {
        public String mot =  null;
        public int pv = 0;

        public solo()
        {
            InitializeComponent();
        }

        private void solo_Load(object sender, EventArgs e)
        {
            string[] mots = File.ReadAllLines(@"mots.txt"); //lecture du fichier de mots
            Random random = new Random(); // nouveau nombre aléatoire
            int index_random = random.Next(0, mots.Length); // choisi un nombre au hasard dans le fichier
            mot = mots[index_random]; // defini un mot au hasard dans la liste
            mot = mot.ToLower(); // enlève les lettres capitales

            pictureBox1.Image = JeuDuPendu.Properties.Resources._0;

            String mot_cache = "";
            for(int i = 0; i < mot.Length; i++)
            {
                mot_cache = mot_cache + "-";
            }
            label1.Text = mot_cache;

        }

        private void VerifLettre(object sender) // fonction pour trouver si la lettre est dans le mot ou pas
        {

            if((sender as Button).BackColor == Color.Green || (sender as Button).BackColor == Color.Red) // vérifie si on a pas déjà utiliser la lettre
            {
                MessageBox.Show("Lettre déja utilisée :/");
                return;
            }

            String lettre = (sender as Button).Text;
            lettre = lettre.ToLower();
            if (mot.Contains(lettre))
            {
                (sender as Button).BackColor = Color.Green;
                
                for( int i = 0;i < mot.Length; i++)
                {
                    if (mot[i] == lettre.ToCharArray()[0]) {
                        char[] array = label1.Text.ToCharArray();
                        array[i] = lettre.ToCharArray()[0];
                        label1.Text = new string(array);

                        if (label1.Text == mot)
                        {
                            MessageBox.Show($"Félicitations vous avez trouvé le mot {mot} !", "Félicitations");
                            this.Hide();
                            Form1 form = new Form1();
                            form.ShowDialog();

                        }
                    }
                }
            }
            else
            {
                (sender as Button).BackColor = Color.Red;
                pv++;
                switch (pv)
                {
                    case 1:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._1;
                        break;
                    case 2:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._2;
                        break;
                    case 3:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._3;
                        break;
                    case 4:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._4;
                        break;
                    case 5:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._5;
                        break;
                    case 6:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._6;
                        break;
                    case 7:
                        pictureBox1.Image = JeuDuPendu.Properties.Resources._7;
                        MessageBox.Show($"vous avez perdu !\nLe mot a deviné été {mot}", "Perdu :/");
                        this.Hide();
                        Form1 form = new Form1();
                        form.ShowDialog();
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            VerifLettre(sender);
        }

        private void solo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
