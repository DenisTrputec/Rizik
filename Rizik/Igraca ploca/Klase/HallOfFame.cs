namespace Igraca_ploca.Klase
{
    public class HallOfFame
    {
        private string imeIgraca;
        private int brojOdigranihIgra;
        private int brojPobjeda;
        private long ukupnoVrijemeIgranja;

        public HallOfFame() : this("", 0, 0, 0) { }

        public HallOfFame(string imeIgraca, int brojOdigranihIgra, int brojPobjeda, long ukupnoVrijemeIgranja)
        {
            this.imeIgraca = imeIgraca;
            this.brojOdigranihIgra = brojOdigranihIgra;
            this.brojPobjeda = brojPobjeda;
            this.ukupnoVrijemeIgranja = ukupnoVrijemeIgranja;
        }

        public string ImeIgraca
        {
            get { return imeIgraca; }
            set { imeIgraca = value; }
        }

        public int BrojOdigranihIgra
        {
            get { return brojOdigranihIgra; }
            set { brojOdigranihIgra = value; }
        }

        public int BrojPobjeda
        {
            get { return brojPobjeda; }
            set { brojPobjeda = value; }
        }

        public long UkupnoVrijemeIgranja
        {
            get { return ukupnoVrijemeIgranja; }
            set { ukupnoVrijemeIgranja = value; }
        }

        public override string ToString()
        {
            return ImeIgraca + "," + BrojOdigranihIgra + "," + BrojPobjeda + "," + UkupnoVrijemeIgranja;
        }
    }

}
