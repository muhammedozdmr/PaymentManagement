using GuvenliAlımSatım;
using GuvenliAlimSatim.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuvenliAlimSatim.UI.Alici
{
    public partial class ReferansKoduGirisForm : Form
    {
        private GuvenliAlimSatimDbContext dbConext = new GuvenliAlimSatimDbContext();
        public ReferansKoduGirisForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var referansKodu = int.Parse(txtReference.Text);

            if (dbConext.Basvuru.FirstOrDefault(b => b.ReferansKod == referansKodu) != null)
            {
                var aliciBasvuruForm = new AliciBasvuruForm(referansKodu);
                aliciBasvuruForm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Bu referans kodunda bir kayıt bulunamadı");
            }
        }
    }
}
