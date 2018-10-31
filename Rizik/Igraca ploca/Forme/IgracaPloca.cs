using Igraca_ploca.Klase;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Igraca_ploca
{
    public partial class IgracaPloca : Form
    {
        private List<Drzava> drzave;
        private Igrac igrac1;
        private Igrac igrac2;

        private HallOfFame igracHOF = new HallOfFame("...", 0, 0, 0);
                                     
        private Igrac trenutniIgrac;
        private Drzava drzavaKojaNapada;

        private bool dodavanjeTenkova = true;
        private int preostaloTenkova = 0;

        private DateTime vrijemePocetkaPartije = DateTime.Now; 
        private GlavniIzbornik gi = new GlavniIzbornik();


        public IgracaPloca(Igrac igrac1, Igrac igrac2)
        {
            InitializeComponent();

            this.igrac1 = igrac1;
            this.igrac2 = igrac2;

            postaviIgru();   //60
        }

        private void inicijalizirajDrzave()
        {
            drzave = new List<Drzava>()
            {
                new Drzava(null, 5, 1, new List<int> () { 0, 1, 8 }, new Point(150, 50)),
                new Drzava(null, 5, 2, new List<int> () { 2, 3, 4, 9, 11 }, new Point(350, 50)),
                new Drzava(null, 5, 3, new List<int> () { 5, 12, 13, 20 }, new Point(600, 150)),
                new Drzava(null, 5, 4, new List<int> () { 6 }, new Point(650, 50)),
                new Drzava(null, 5, 5, new List<int> () { 7,14 }, new Point(50, 200)),
                new Drzava(null, 5, 6, new List<int> () { 10 }, new Point(350, 150)),
                new Drzava(null, 5, 7, new List<int> () { 15, 16, 17 }, new Point(250, 250)),
                new Drzava(null, 5, 8, new List<int> () { 18, 19, 25, 26 }, new Point(500, 300)),
                new Drzava(null, 5, 9, new List<int> () { 21, 22, 28 }, new Point(50, 350)),
                new Drzava(null, 5, 10, new List<int> () { 23 }, new Point(250, 350)),
                new Drzava(null, 5, 11, new List<int> () { 24 }, new Point(350, 350)),
                new Drzava(null, 5, 12, new List<int> () { 27, 34 }, new Point(650, 400)),
                new Drzava(null, 5, 13, new List<int> () { 29, 30 }, new Point(200, 450)),
                new Drzava(null, 5, 14, new List<int> () { 31, 32, 33 }, new Point(450, 450))
            };

            foreach (Drzava dr in drzave)
                dr.dodajSusjede(drzave);
        }

        private void postaviIgru()
        {
            inicijalizirajDrzave();  //36
            vrijemePocetkaPartije = DateTime.Now;
            Random rand = new Random();

            igrac1.BrojTeritorija = igrac2.BrojTeritorija = 0;

            foreach(Drzava drzava in drzave)
            {
                int broj = rand.Next();
                if(broj % 2 == 0)
                {
                    if (igrac2.BrojTeritorija >= 7)
                        drzava.Vlasnik = igrac1;
                    else drzava.Vlasnik = igrac2;
                }
                else
                {
                    if (igrac1.BrojTeritorija >= 7)
                        drzava.Vlasnik = igrac2;
                    else drzava.Vlasnik = igrac1;
                }
                drzava.Vlasnik.BrojTeritorija++;
            }
            trenutniIgrac = igrac1;
            label_TrenutniIgrac.Text = igrac1.ImeIgraca;
            drzavaKojaNapada = null;

            label_brPobjeda1.Text = igrac1.ImeIgraca + ": " + igrac1.BrojPobjeda;
            label_brPobjeda2.Text = igrac2.ImeIgraca + ": " + igrac2.BrojPobjeda;

            panel_polje.Refresh();
            dodavanjeTenkovaFunk();   //209
        }

        private int pronadjiCesticu(int X, int Y)
        {
            int cestica = -1;
            bool pronadjenaCestica = false;

            for (int y = 100; y <= 500 && !pronadjenaCestica; y += 100)
                for (int x = 100; x <= 700 && !pronadjenaCestica; x += 100, cestica++)
                    if (X < x && Y < y)
                        pronadjenaCestica = true;

            return cestica;
        }

        private Drzava pronadjiDrzavu(int cestica)
        {
            Drzava drzava = null;

            foreach (Drzava dr in drzave)
                if (dr.provjeriZemljisnuKnjigu(cestica))
                {
                    drzava = dr;
                    break;
                }
            return drzava;
        }

        private void panel_bojnoPolje_MouseUp(object sender, MouseEventArgs e)
        {
            int cestica = pronadjiCesticu(e.X, e.Y);   //95
            Drzava drzava = pronadjiDrzavu(cestica);   //108

            if (dodavanjeTenkova)
            {
                if (drzava.Vlasnik == trenutniIgrac) {
                    drzava.BrojTenkova++;
                    preostaloTenkova--;
                    label_PostavljanjeTenkova.Text = "Broj tenkova za postaviti: " + preostaloTenkova;
                    panel_polje.Refresh();
                }
                if (preostaloTenkova == 0)
                {
                    MessageBox.Show("Krenite sa napadom!");
                    dodavanjeTenkova = false;
                }
                return;
            }

            if (drzavaKojaNapada == null && (drzava.Vlasnik != trenutniIgrac || drzava.BrojTenkova <= 1))
            {
                return;
            }
            
            if (drzavaKojaNapada == null && e.Button == MouseButtons.Left)
            { 
                drzavaKojaNapada = drzava;
                panel_polje.Refresh();
                return;
            }
            else if( drzava == drzavaKojaNapada && e.Button == MouseButtons.Right)
            {
                drzavaKojaNapada = null;
                panel_polje.Refresh();
                return;
            }

            if(drzava.Vlasnik != trenutniIgrac && drzavaKojaNapada.provjeraSusjedstva(drzava) && e.Button == MouseButtons.Left)
            {
                napad(drzavaKojaNapada, drzava);   //166
            }
        }

        private void napad(Drzava napadac, Drzava branitelj)
        {
            Random rand = new Random();
            while(napadac.BrojTenkova > 1 && branitelj.BrojTenkova > 0)
            {
                int kockaNapadac = rand.Next(1, 7);
                int kockaBranitelj = rand.Next(1, 7);

                if (kockaNapadac > kockaBranitelj)
                    branitelj.BrojTenkova--;
                else
                    napadac.BrojTenkova--;
            }

            if(branitelj.BrojTenkova == 0)
            {
                branitelj.Vlasnik.BrojTeritorija--;
                branitelj.Vlasnik = napadac.Vlasnik;
                napadac.Vlasnik.BrojTeritorija++;
                new PremjestanjeTenkova(napadac, branitelj).ShowDialog();
            }
            
            else if(napadac.BrojTenkova == 1)
            {
                MessageBox.Show("Igrač " + branitelj.Vlasnik.ImeIgraca + " je pobjedio u bitci! \n\nPreživjeli broj tenkova: " + branitelj.BrojTenkova, "Poraz!");
            }

            if (napadac.Vlasnik.BrojTeritorija == 14)
            {
                if (MessageBox.Show("Pobjedio je " + napadac.Vlasnik.ImeIgraca + "\nŽelite li novu igru?", "Pobjeda!"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    napadac.Vlasnik.BrojPobjeda++;
                    Igrac igrac0 = napadac.Vlasnik == igrac1 ? igrac2 : igrac1;
                    spremanje(napadac.Vlasnik, igrac0);
                    postaviIgru();    //60
                }
                else
                {
                    Igrac igrac0 = napadac.Vlasnik == igrac1 ? igrac2 : igrac1;
                    spremanje(napadac.Vlasnik, igrac0);
                    izlazIzIgre();    //242
                }
            }
            else
            {
                promjeniIgraca();     //218
                panel_polje.Refresh();
            }
        }

        private void dodavanjeTenkovaFunk()
        {
            dodavanjeTenkova = true;
            preostaloTenkova = (trenutniIgrac.BrojTeritorija / 2 + 1);
            MessageBox.Show("Pristiglo je pojačanje za igrača: " + trenutniIgrac.ImeIgraca + "\nMolimo vas rasporedite tenkove (broj tenkova: " + preostaloTenkova + ").", "Pojačanje!");
            label_PostavljanjeTenkova.Text = "Broj tenkova za postaviti: " + preostaloTenkova;
        }

        private void promjeniIgraca()
        {
            trenutniIgrac = (trenutniIgrac == igrac1) ? igrac2 : igrac1;
            drzavaKojaNapada = null;
            dodavanjeTenkovaFunk();      //210
            label_TrenutniIgrac.Text = trenutniIgrac.ImeIgraca;
        }

        private void refreshBojnogPolja(object sender, PaintEventArgs e)
        {
            if (drzave == null)
                return;
            foreach (Drzava drzava in drzave)
                drzava.crtajKrug(e.Graphics);
            if (drzavaKojaNapada != null)
                drzavaKojaNapada.crtajKruznicu(e.Graphics);
        }

        private void button_zavrsiPotez_Click(object sender, EventArgs e)
        {
            promjeniIgraca();          //218
            panel_polje.Refresh();
        }

        private void spremanje(Igrac pobjednik, Igrac gubitnik)
        {
            Rizik.Klase.Statistika.Spremi(pobjednik, gubitnik, vrijemePocetkaPartije);
        }

        private void izlazIzIgre()
        {
            panel_polje.Refresh();
            Close();
        }

        private void button_izlaz_Click(object sender, EventArgs e)
        {
             izlazIzIgre();  //242
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "\nJeste li sigurni?", "Izlaz iz igre!", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}
