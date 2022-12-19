using GuvenliAlımSatım;
using GuvenliAlimSatim.Business;
using GuvenliAlimSatim.DataAccess;
using GuvenliAlimSatim.UI.Satici;

namespace GuvenliAlimSatim.UI
{
    public partial class SatisBasvuruForm : Form
    {
        private GuvenliAlimSatimDbContext dbContext = new GuvenliAlimSatimDbContext();
        public SatisBasvuruForm()
        {
            InitializeComponent();
        }

        private void btnSellerSave_Click(object sender, EventArgs e)
        {
            var sendSms = new SendSMS();
            var smsCode = sendSms.SMS();
            MessageBox.Show($"SMS Kodunuz: {smsCode}");
            var _smsDogrulama = new SmsDogrulamaForm(smsCode);
            _smsDogrulama.FormClosed += _smsDogrulama_FormClosed;
            var referansKod = new SendReference();
            var referans = referansKod.Reference();
            var resultDialog = _smsDogrulama.ShowDialog();
            if (resultDialog == DialogResult.OK)
            {
                var aracSatis = new Basvuru()
                {
                    GercekTuzel_IdSatici = (int)cmbGercekTuzel.SelectedValue,
                    ReferansKod = referans,
                    TCKimlikSatici = txtTCKimlik.Text,
                    SaticiAdSoyad = txtSaticiAdSoyad.Text,
                    SaticiCep = txtSaticiCep.Text,
                    SaticiEPosta = txtSaticiEposta.Text,
                    AliciCep = txtAliciCep.Text,
                    AliciEPosta = txtAliciEposta.Text,
                    SaticiIBAN = txtSaticiIban.Text,
                    AracPlaka = txtAracPlaka.Text,
                    SatisTutari = numSatisFiyati.Value,
                    RizaMetni = chkRizaMetni.Checked,
                    ReklamMetni = chkReklamMetni.Checked,
                    SaticiBasvuruTarih = DateTime.Now,
                };
                MessageBox.Show($"Referans numaras: {referans}");
                var senderData = dbContext.Basvuru.Add(aracSatis);
                dbContext.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Olmadı");
            }
        }

        private void _smsDogrulama_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var kullaniciPanel = new KullaniciPanelForm();
            kullaniciPanel.Show();
        }

        private void SatisBasvuruForm_Load(object sender, EventArgs e)
        {
            var gercekTuzel = dbContext.GercekTuzel.ToList();
            cmbGercekTuzel.DataSource = gercekTuzel;
            cmbGercekTuzel.DisplayMember = "Unvan";
            cmbGercekTuzel.ValueMember = "Id";
        }
    }
}
