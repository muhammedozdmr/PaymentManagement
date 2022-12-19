using GuvenliAlımSatım;
using GuvenliAlimSatim.Business;
using GuvenliAlimSatim.DataAccess;
using GuvenliAlimSatim.UI.Satici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenliAlimSatim.UI.Main
{
    public partial class BasvuruSilmeForm : Form
    {
        private GuvenliAlimSatimDbContext dbContext = new GuvenliAlimSatimDbContext();
        private Basvuru basvuru;
        private KullaniciPanelForm anaSayfa = new KullaniciPanelForm();
        public BasvuruSilmeForm()
        {
            InitializeComponent();
        }

        private void BasvuruSilmeForm_Load(object sender, EventArgs e)
        {
            var gercekTuzel = dbContext.GercekTuzel.ToList();
            cmbGercekTuzel.DataSource = gercekTuzel;
            cmbGercekTuzel.DisplayMember = "Unvan";
            cmbGercekTuzel.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            basvuru = dbContext.Basvuru.FirstOrDefault(s => s.ReferansKod == int.Parse(txtReferans.Text));

            var tcKimlikSatici = basvuru.TCKimlikSatici;
            var telefonSatici = basvuru.SaticiCep;
            var tcKimlikAlici = basvuru.TCKimlikAlici;
            var telefonAlici = basvuru.AliciCep;
            var tcKimlik = txtTcKimlik.Text;
            var telefon = txtTelefon.Text;
            if (basvuru == null)
            {
                MessageBox.Show("Hatalı giriş yada silme işlemi yapılacak kayıt yok !");
            }
            else
            {
                if ((tcKimlikSatici == tcKimlik && telefonSatici == telefon) || (tcKimlikAlici == tcKimlik && telefonAlici == telefon))
                {
                    if (tcKimlikSatici == tcKimlik && telefonSatici == telefon)
                    {
                        basvuru.IptalDurum = true;
                        basvuru.IptalNedeni = txtIptalNedeni.Text;
                        dbContext.Basvuru.Update(basvuru);
                    }
                    else if (tcKimlikAlici == tcKimlik && telefonAlici == telefon)
                    {
                        basvuru.IptalDurum = true;
                        basvuru.IptalNedeni = txtIptalNedeni.Text;
                        dbContext.Basvuru.Update(basvuru);
                    }

                    var sendSms = new SendSMS();
                    var smsCode = sendSms.SMS();
                    MessageBox.Show($"SMS Kodunuz: {smsCode}");
                    var _smsDogrulama = new SmsDogrulamaForm(smsCode);
                    var resultDialog = _smsDogrulama.ShowDialog();
                    if (resultDialog == DialogResult.OK)
                    {
                        dbContext.SaveChanges();
                        var dialog = MessageBox.Show($"{basvuru.ReferansKod} referans kodlu başvurunuz iptal edilmiştir.\nAna sayfaya dönemk ister misiniz ?",
                            "İptal işlemi tamamlandı",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialog == DialogResult.Yes)
                        {
                            Close();
                            anaSayfa.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kimlik bilgileri yada telefon bilgileri hatalı !");
                }
            }
        }

        private void btnRemember_Click(object sender, EventArgs e)
        {
            var referansHatirlatici = new ReferansHatirlatici();
            referansHatirlatici.ShowDialog();
            
        }
    }
}
