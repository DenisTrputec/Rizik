using Igraca_ploca.Klase;
using System.Windows.Forms;

namespace Igraca_ploca
{
    public partial class PremjestanjeTenkova : Form
    {
        private Drzava napadac, branitelj;

        public PremjestanjeTenkova(Drzava napadac, Drzava branitelj)
        {
            InitializeComponent();
            this.napadac = napadac;
            this.branitelj = branitelj;
            label_Pobjednik.Text += napadac.Vlasnik.ImeIgraca + " je pobjedio u bitci!";
            label_Premjestanje.Text += " (broj preživjelih tenkova: " + (napadac.BrojTenkova-1) + ")";
            sliderOdabrano.SetRange(1, napadac.BrojTenkova - 1);
            brojTenkova.Text = sliderOdabrano.Value.ToString();
        }

        private void buttonPremjestiClick(object sender, System.EventArgs e)
        {
            napadac.BrojTenkova -= sliderOdabrano.Value;
            branitelj.BrojTenkova += sliderOdabrano.Value;
            Close();
        }

        private void sliderOdabrano_Scroll(object sender, System.EventArgs e)
        {
            brojTenkova.Text = sliderOdabrano.Value.ToString();
        }
    }
}
