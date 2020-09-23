using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuCaractere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EventSaisieChaine(object sender, EventArgs e)
        {
            int chiffre = textBox1.Text.Length;

            numericUpDown1.Maximum = chiffre;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 1;




        }

        private void EventRes(object sender, EventArgs e)
        {
            decimal valeurcarac = numericUpDown1.Value;
            int indicecarac = (int)valeurcarac -1;
            string chaine = textBox1.Text.Substring(indicecarac, 1);
            char carac = char.Parse(chaine);

            if (char.IsDigit(carac))
            {
                textBox3.Text = "nombre entier";
            }
            else if (char.IsLetter(carac))
            {
                textBox3.Text = "lettre";
            }
            else if (char.IsPunctuation(carac))
            {
                textBox3.Text = "ponctuation";
            }
            else
            {
                textBox3.Text = "XX";
            }
        }
    }
}
