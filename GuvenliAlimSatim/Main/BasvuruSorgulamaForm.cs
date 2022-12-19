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
    public partial class BasvuruSorgulamaForm : Form
    {
        private GuvenliAlimSatimDbContext dbContext = new GuvenliAlimSatimDbContext();
        private Basvuru basvuru;
        private BasvuruDetayForm basvuruDetay;
        public BasvuruSorgulamaForm()
        {
            InitializeComponent();
        }

        private void BasvuruSorgulamaForm_Load(object sender, EventArgs e)
        {
            var gercekTuzel = dbContext.GercekTuzel.ToList();
            cmbGercekTuzel.DataSource = gercekTuzel;
            cmbGercekTuzel.DisplayMember = "Unvan";
            cmbGercekTuzel.ValueMember = "Id";
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            var gercekTuzel = (int)cmbGercekTuzel.SelectedValue;
            var tc = txtTcKimlik.Text;
            var telefon = txtTelefon.Text;
            var referans = txtReferans.Text;
            basvuru = dbContext.Basvuru.FirstOrDefault(s => s.ReferansKod.ToString() == txtReferans.Text);
            if (((basvuru.TCKimlikSatici == tc && basvuru.SaticiCep == telefon) ||
                (basvuru.TCKimlikAlici == tc && basvuru.AliciCep == telefon)) &&
                basvuru != null)
            {
                var sendSms = new SendSMS();
                var smsCode = sendSms.SMS();
                MessageBox.Show($"SMS Kodunuz: {smsCode}");
                var _smsDogrulama = new SmsDogrulamaForm(smsCode);
                var resultDialog = _smsDogrulama.ShowDialog();
                if (resultDialog == DialogResult.OK)
                {
                    if (basvuru.TCKimlikAlici == null)
                    {
                        basvuruDetay = new BasvuruDetayForm(referans, "Alıcı başvurusu bekleniyor.", "(Alıcı yok) Ödeme durumu bilinmiyor");
                    }
                    else if (basvuru.TCKimlikAlici != null && basvuru.OdemeDurum == false)
                    {
                        basvuruDetay = new BasvuruDetayForm(referans, "Alıcı başvurusu yapıldı.", "Ödeme durumu bekleniyor..");
                    }
                    else if(basvuru.TCKimlikAlici != null && basvuru.OdemeDurum==true)
                    {
                        basvuruDetay = new BasvuruDetayForm(referans, "Alıcı başvurusu yapıldı.", "Ödeme yapıldı...");
                    }
                    else if (basvuru.IptalDurum == true)
                    {
                        basvuruDetay = new BasvuruDetayForm(referans, "Alıcı başvurusu iptal edildi","");
                    }
                    basvuruDetay.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Sorgulama Bilgileri Hatalı !\nSatıcı ve alıcı bulunmuyor !");
            }
        }
    }
}
