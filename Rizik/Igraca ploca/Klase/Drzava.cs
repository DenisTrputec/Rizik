using System;
using System.Collections.Generic;
using System.Drawing;

namespace Igraca_ploca.Klase
{
    public class Drzava
    {
        private Igrac vlasnik;
        private int brojTenkova;
        private int brojDrzave;    //Ime države
        private List<int> listaCestica;   //Čestice koje čine državu
        private List<Drzava> listaSusjeda;  
        private Point lokacijaKruznice;

        public Drzava(Igrac vlasnik, int brojTenkova, int brojDrzave, List<int> cestice, Point lokacijaKruznice)
        {
            this.vlasnik = vlasnik;
            this.brojTenkova = brojTenkova;
            this.brojDrzave = brojDrzave;
            this.listaCestica = cestice;
            this.lokacijaKruznice = lokacijaKruznice;
            listaSusjeda = new List<Drzava>();
        }

        public Igrac Vlasnik
        {
            get
            {
                return vlasnik;
            }

            set
            {
                vlasnik = value;
            }
        }

        public int BrojTenkova
        {
            get
            {
                return brojTenkova;
            }

            set
            {
                brojTenkova = value;
            }
        }

        public int BrojDrzave
        {
            get
            {
                return brojDrzave;
            }

            set
            {
                brojDrzave = value;
            }
        }

        public List<int> Cestice
        {
            get
            {
                return listaCestica;
            }

            set
            {
                listaCestica = value;
            }
        }

        public List<Drzava> Susjedi
        {
            get
            {
                return listaSusjeda;
            }

            set
            {
                listaSusjeda = value;
            }
        }

        public bool provjeriZemljisnuKnjigu(int cestica)
        {
            return listaCestica.Contains(cestica);
        }

        public void dodajSusjede(List<Drzava> sveDrzave)
        {
            foreach(Drzava dr in sveDrzave)
            {
                if (dr.brojDrzave == brojDrzave)
                    continue;
                foreach(int cestica in listaCestica)
                {
                    bool susjed = (dr.provjeriZemljisnuKnjigu(cestica - 1) && (cestica % 7) != 0) 
                               || (dr.provjeriZemljisnuKnjigu(cestica + 1) && (cestica % 7) != 6) 
                               || dr.provjeriZemljisnuKnjigu(cestica - 7) 
                               || dr.provjeriZemljisnuKnjigu(cestica + 7);

                    if (susjed && !listaSusjeda.Contains(dr))
                        listaSusjeda.Add(dr);
                }
            }
        }

        public bool provjeraSusjedstva(Drzava drzava)
        {
            return listaSusjeda.Contains(drzava);
        }

        public void crtajKrug(Graphics slikaBojnoPolje)
        {
            slikaBojnoPolje.FillEllipse(new SolidBrush(Vlasnik.BojaIgraca), lokacijaKruznice.X - 25, lokacijaKruznice.Y - 25, 50, 50);

            int oduzmiX = BrojTenkova < 10 ? 9 : 14;

            slikaBojnoPolje.DrawString(BrojTenkova.ToString(), new Font("Times New Roman", 16f, FontStyle.Bold)
                    , new SolidBrush(Color.Black), lokacijaKruznice.X - oduzmiX, lokacijaKruznice.Y - 12);
        }

        public void crtajKruznicu(Graphics slikaBojnoPolje)
        {
            slikaBojnoPolje.DrawEllipse(new Pen(Color.Orange, 5f), lokacijaKruznice.X - 25, lokacijaKruznice.Y - 25, 50, 50);
        }
    }
}
