using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jeu_bataille
{
    public partial class Form1 : Form
    {
        private Paquet pack;
        private Joueur J1;
        private Joueur J2;
        Random random =new Random();
        List<Carte> packJ1, packJ2, packBataille;
        int i;
        int nbr_cartes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = false;

            pack = new Paquet();

            packJ1 = new List<Carte>();
            packJ2 = new List<Carte>();

            pack.MelangerCarte();
            
            for (int i = 0; i < 16; i++)
            {
                packJ1.Add(pack.GetCartes());
                listBox1.Items.Add(packJ1[i].getCouleur() + " " +packJ1[i].getValeur());
                packJ2.Add(pack.GetCartes());
                listBox2.Items.Add(packJ2[i].getCouleur()+ " " + packJ2[i].getValeur());

            }

            label3.Text = packJ1.Count().ToString();
            label4.Text = packJ2.Count().ToString();
          
            
            J1 = new Joueur("azertyui", packJ1);
            J2 = new Joueur("sdfui", packJ2);

            label1.Text = J1.GetNom();
            label2.Text = J2.GetNom();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            packBataille = new List<Carte>();
            pictureBox2.ImageLocation = ".\\Cartes\\" + packJ1[0].getCouleur() + packJ2[0].getValeur() + ".jpg";
            pictureBox1.ImageLocation = ".\\Cartes\\" + packJ2[0].getCouleur() + packJ2[0].getValeur() + ".jpg";

            
            if (packJ1[i].getValeur() > packJ2[i].getValeur())
            {
                if (packBataille.Count > 0)
                {
                    foreach (Carte c in packBataille)
                    {
                        packJ1.Add(c);
                    }
                }
                packJ1.Add(packJ2[i]);
                listBox1.Items.Add(packJ2[i].getCouleur() + " " + packJ2[i].getValeur());
                packJ2.RemoveAt(i);
                listBox2.Items.RemoveAt(i);

                label3.Text = packJ1.Count().ToString();
                label4.Text = packJ2.Count().ToString();
            }
            else if (packJ2[i].getValeur() > packJ1[i].getValeur())
            {
                if (packBataille.Count > 0)
                {
                    foreach (Carte c in packBataille)
                    {
                        packJ2.Add(c);
                    }
                }
                packJ2.Add(packJ1[i]);
                listBox2.Items.Add(packJ1[i].getCouleur() + " " + packJ1[i].getValeur());
                packJ1.RemoveAt(i);
                listBox1.Items.RemoveAt(i);

                label3.Text = packJ1.Count().ToString();
                label4.Text = packJ2.Count().ToString();
            }
            else
            {

                packBataille.Add(packJ1[i]);
                packBataille.Add(packJ2[i]);
                i++;
            }

            if (packJ1.Count == 0)
            {
                label5.Visible = true;
                label5.Text = "Le joureur 1 a gagné la partie";
            }
            if (packJ2.Count == 0)
            {
                label5.Visible = true;
                label5.Text = "Le joureur 2 a gagné la partie";
            }
            /**/
        }
    }
}
