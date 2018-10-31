using System.Drawing;

namespace Igraca_ploca.Klase
{
    public class Igrac
    {
        private string imeIgraca;
        private Color bojaIgraca;

        private int brojTeritorija;

        private int brojPobjeda;

        public Igrac(string imeIgraca, Color bojaIgraca)
        {
            this.imeIgraca = imeIgraca;
            this.bojaIgraca = bojaIgraca;
        }

        public string ImeIgraca
        {
            get { return imeIgraca; }
        }

        public Color BojaIgraca
        {
            get { return bojaIgraca; }
        }

        public int BrojTeritorija
        {
            get { return brojTeritorija; }
            set { brojTeritorija = value; }
        }

        public int BrojPobjeda
        {
            get { return brojPobjeda; }
            set { brojPobjeda = value; }
        }
    }
}
