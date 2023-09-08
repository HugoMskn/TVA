using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateurTVA
{
    public partial class Form1 : Form
    {
        public double TauxTVA = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TauxTVA = 20;
            label1.Text = "Taux TVA : 20%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TauxTVA = 10;
            label1.Text = "Taux TVA : 10%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TauxTVA = 5.5;
            label1.Text = "Taux TVA : 5,5%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double prix = double.Parse(textBox1.Text);
            double resultat = prix / (1 + TauxTVA / 100);
            richTextBox1.AppendText("Prix HT : " + resultat +" Prix d'origine : " + prix +$" TVA : {prix - resultat}" + "\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double prix = double.Parse(textBox1.Text);
            double resultat = prix * (1 + TauxTVA / 100);
            richTextBox1.AppendText("Prix TTC : " + resultat + " Prix d'origine : " + prix +$" TVA : {prix - resultat}"+"\n");
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try {
                    TauxTVA = int.Parse(textBox2.Text);
                    label1.Text = $"Taux TVA : {textBox2.Text}%";

                }
                catch
                {
                    MessageBox.Show("Veuillez entrer un taux correct");
                }
                    
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
    }
}
