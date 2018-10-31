using Igraca_ploca.Klase;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Igraca_ploca
{
    public partial class PocetniEkran : Form
    {
        public PocetniEkran()
        {
            InitializeComponent();
        }
        private void button_Kreni_Click(object sender, EventArgs e)
        {
            string imeIgraca1 = "", imeIgraca2 = "";
            string bojaIg1 = "", bojaIg2 = "";
            imeIgraca1 = textBox_Igrac1.Text;
            imeIgraca2 = textBox_Igrac2.Text;
            foreach (RadioButton rb in groupBox_Igrac1.Controls)
                if (rb.Checked)
                    bojaIg1 = rb.Text;
            foreach (RadioButton rb in groupBox_Igrac2.Controls)
                if (rb.Checked)
                    bojaIg2 = rb.Text;

            if(imeIgraca1.Length == 0 || imeIgraca2.Length == 0)
            {
                MessageBox.Show("Unesite imena igrača!");
                return;
            }
            if(bojaIg1.Length == 0 || bojaIg2.Length == 0)
            {
                MessageBox.Show("Odaberite boje igrača!");
                return;
            }

            Color bojaIgraca1;
            Color bojaIgraca2;

            if (bojaIg1 == "Crvena")
                bojaIgraca1 = Color.Red;
            else if (bojaIg1 == "Plava")
                bojaIgraca1 = Color.Blue;
            else if (bojaIg1 == "Žuta")
                bojaIgraca1 = Color.Yellow;
            else
                bojaIgraca1 = Color.Green;

            if (bojaIg2 == "Crvena")
                bojaIgraca2 = Color.Red;
            else if (bojaIg2 == "Plava")
                bojaIgraca2 = Color.Blue;
            else if (bojaIg2 == "Žuta")
                bojaIgraca2 = Color.Yellow;
            else
                bojaIgraca2 = Color.Green;

            Igrac igrac1 = new Igrac(imeIgraca1, bojaIgraca1);
            Igrac igrac2 = new Igrac(imeIgraca2, bojaIgraca2);

            IgracaPloca ip = new IgracaPloca(igrac1, igrac2);

            ip.Show();
            ip.FormClosed += (a, aa) => { Close(); }; //Funkcija koja se prosljeđuje formi IgracaPloca da bi se prilikom njenog gasenja ugasila i trenutna forma PocetniEkran
            Hide();
        }

        private void odabirIgrac(object sender, EventArgs e)
        {
            radioButton_Crvena1.Enabled = !radioButton_Crvena2.Checked;
            radioButton_Crvena2.Enabled = !radioButton_Crvena1.Checked;
            radioButton_Plava1.Enabled = !radioButton_Plava2.Checked;
            radioButton_Plava2.Enabled = !radioButton_Plava1.Checked;

            radioButton_Zuta1.Enabled = !radioButton_Zuta2.Checked;
            radioButton_Zuta2.Enabled = !radioButton_Zuta1.Checked;
            radioButton_Zelena1.Enabled = !radioButton_Zelena2.Checked;
            radioButton_Zelena2.Enabled = !radioButton_Zelena1.Checked;
        }

        private void button_Povratak_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}