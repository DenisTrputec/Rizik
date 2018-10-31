using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using Rizik.Klase;

namespace Igraca_ploca
{
    public partial class GlavniIzbornik : Form
    {
        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        private List<Klase.HallOfFame> statistika = new List<Klase.HallOfFame>();
        private void button_NovaIgra_Click(object sender, EventArgs e)
        {
            PocetniEkran pe = new PocetniEkran();

            pe.Show();
            pe.FormClosed += (a, aa) => { Show(); };
            Hide();
        }

        private void button_Izlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Statistika_Click(object sender, EventArgs e)
        {
            statistika = Statistika.Ucitaj();
            string hallOfFame = "Ime\tOdigrano\t  Pobjede\t  Vrijeme (min)" + Environment.NewLine;

            int brojIgraca = 0;
            foreach (var hof in statistika)
            {
                hallOfFame += hof.ImeIgraca + "\t" + hof.BrojOdigranihIgra + "\t  " + hof.BrojPobjeda + "\t  " + hof.UkupnoVrijemeIgranja + Environment.NewLine;
                if (++brojIgraca == 10)
                    break;
            }

            if (statistika.Count == 0)
                hallOfFame += "Nema odigranih partija!";

            MessageBox.Show(hallOfFame, "Statistika");
        }
        private void button_PravilaIgre_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("Pravila igre.txt");
            MessageBox.Show(text,"Pravila igre");
        }

        private void button_O_Igri_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("O igri.txt");
            MessageBox.Show(text, "O igri");
        }
    }
}
