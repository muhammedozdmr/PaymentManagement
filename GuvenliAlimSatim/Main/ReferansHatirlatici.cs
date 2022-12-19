using GuvenliAlımSatım;
using GuvenliAlimSatim.DataAccess;

namespace GuvenliAlimSatim.UI.Main
{
    public partial class ReferansHatirlatici : Form
    {
        private GuvenliAlimSatimDbContext dbContext = new GuvenliAlimSatimDbContext();
        private Basvuru basvuru;
        public ReferansHatirlatici()
        {
            InitializeComponent();
        }

        private void btnSendReference_Click(object sender, EventArgs e)
        {
            basvuru = dbContext.Basvuru.FirstOrDefault(b => b.SaticiCep == txtTelefon.Text || b.AliciCep == txtTelefon.Text);
            if (basvuru != null)
            {
                var referans = dbContext.Basvuru.Where(b => b.SaticiCep == txtTelefon.Text || b.AliciCep == txtTelefon.Text).Select(b => b.ReferansKod).FirstOrDefault();
                MessageBox.Show($"Referans Kodunuz: {referans}");
            }
            Close();
        }
    }
}
