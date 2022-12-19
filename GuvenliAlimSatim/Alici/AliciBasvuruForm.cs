using GuvenliAlımSatım;
using GuvenliAlimSatim.Business;
using GuvenliAlimSatim.DataAccess;
using GuvenliAlimSatim.UI.Alici;
using GuvenliAlimSatim.UI.Satici;
using System.Data;

namespace GuvenliAlimSatim.UI
{
    public partial class AliciBasvuruForm : Form
    {
        private readonly int _referansKodu;
        private GuvenliAlimSatimDbContext dbContext = new GuvenliAlimSatimDbContext();
        private Basvuru _basvuru;
        public AliciBasvuruForm(int referansKodu)
        {
            InitializeComponent();
            _referansKodu = referansKodu;
        }

        private void AliciBasvuruForm_Load(object sender, EventArgs e)
        {

            var gercekTuzel = dbContext.GercekTuzel.ToList();
            cmbGercekTuzel.DataSource = gercekTuzel;
            cmbGercekTuzel.DisplayMember = "Unvan";
            cmbGercekTuzel.ValueMember = "Id";

            _basvuru = dbContext.Basvuru.FirstOrDefault(b => b.ReferansKod == _referansKodu);
            lblReferenceCode.Text = _basvuru.ReferansKod.ToString();
            lblSellerName.Text = _basvuru.SaticiAdSoyad;
            lblSellerPhone.Text = _basvuru.SaticiCep;
            lblCarPlate.Text = _basvuru.AracPlaka;
            lblPrice.Text = _basvuru.SatisTutari.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sendSms = new SendSMS();
            var smsCode = sendSms.SMS();
            MessageBox.Show($"SMS Kodunuz: {smsCode}");
            var _smsDogrulama = new SmsDogrulamaForm(smsCode);
            var resultDialog = _smsDogrulama.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                _basvuru.GercekTuzel_IdAlici = (int)cmbGercekTuzel.SelectedValue;
                _basvuru.TCKimlikAlici = txtTCKimlik.Text;
                _basvuru.AliciAdSoyad = txtName.Text;
                _basvuru.AliciCep = txtPhone.Text;

                var senderData = dbContext.Basvuru.Update(_basvuru);
                dbContext.SaveChanges();

                var plate = dbContext.Basvuru.Where(s => s.ReferansKod == _referansKodu).Select(s => s.AracPlaka).FirstOrDefault();
                var result = MessageBox.Show($"{plate} plakalı araç için alıcı başvuru işleminiz yapılmıştır\n" +
                    $"İşlemin onaylanması için para transferi yapmalısınız !", "Transfer Detay", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    var transferDetay = new TransferBilgileriForm(_referansKodu);
                    transferDetay.Owner = this;
                    Hide();
                    transferDetay.Show();
                }
            }

        }
    }
}

