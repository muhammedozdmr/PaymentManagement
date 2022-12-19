namespace GuvenliAlimSatim.UI.Satici
{
    public partial class SmsDogrulamaForm : Form
    {
        private readonly int _sms;


        public SmsDogrulamaForm(int sms)
        {
            InitializeComponent();
            this._sms = sms;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSmsReference.Text == _sms.ToString())
            {
                DialogResult = DialogResult.OK;
                var mainForm = MessageBox.Show("Başvurunuz tamamlandı.\nBaşvuru bilgileriniz telefonunuza gönderildi.", "Ana ekrana dön", MessageBoxButtons.OK);
                if (mainForm == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Başvuru onaylanmadı !\nBaşvuru onay formundan çıkmak istediğinize emin misiniz ?", "Dikkat !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var panelForm = new KullaniciPanelForm();
                panelForm.Show();
            }
        }
    }
}
