using GuvenliAlımSatım;
using GuvenliAlimSatim.UI.Alici;
using GuvenliAlimSatim.UI.Main;

namespace GuvenliAlimSatim.UI
{
    public partial class KullaniciPanelForm : Form
    {
        public KullaniciPanelForm()
        {
            InitializeComponent();
        }

        private void btnSellerForm_Click(object sender, EventArgs e)
        {
            var satisBasvuruForm = new SatisBasvuruForm();
            satisBasvuruForm.Owner=this;
            satisBasvuruForm.Show();
            Hide();
        }

        private void btnBuyerForm_Click(object sender, EventArgs e)
        {
            var referansKoduGirisForm = new ReferansKoduGirisForm();
            referansKoduGirisForm.Owner = this;
            referansKoduGirisForm.Show();
            Hide();
        }

        private void btnApplicationStatus_Click(object sender, EventArgs e)
        {
            var basvuruSorgulamaForm = new BasvuruSorgulamaForm();
            basvuruSorgulamaForm.Owner=this;
            basvuruSorgulamaForm.Show();
            Hide();
        }

        private void btnApplicationCancel_Click(object sender, EventArgs e)
        {
            var basvuruIptalForm = new BasvuruSilmeForm();
            basvuruIptalForm.Owner = this;
            basvuruIptalForm.Show();
            Hide();
        }
    }
}
