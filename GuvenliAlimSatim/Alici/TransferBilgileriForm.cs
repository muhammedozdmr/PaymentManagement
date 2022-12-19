using GuvenliAlımSatım;
using GuvenliAlimSatim.Business;
using GuvenliAlimSatim.DataAccess;
using System.Data;

namespace GuvenliAlimSatim.UI.Alici
{
    public partial class TransferBilgileriForm : Form
    {
        private MasrafRandom _masraf = new MasrafRandom();
        private GuvenliAlimSatimDbContext _dbContext = new GuvenliAlimSatimDbContext();
        private readonly int _referans;
        double masrafTutar = default;

        public TransferBilgileriForm(int referans)
        {
            InitializeComponent();
            this._referans = referans;
        }

        private void TransferBilgileriForm_Load(object sender, EventArgs e)
        {
            var bankalar = _dbContext.Bankalar.ToList();
            cmbBanka.DataSource = bankalar;
            cmbBanka.DisplayMember = "BankaAdi";
            cmbBanka.ValueMember = "Id";
            masrafTutar = _masraf.Masraf();
            lblTransferReferans.Text = _dbContext.Basvuru.Where(s=>s.ReferansKod==_referans).Select(s => s.ReferansKod).FirstOrDefault().ToString();
            lblFiyat.Text = _dbContext.Basvuru.Where(s=>s.ReferansKod==_referans).Select(s => s.SatisTutari).FirstOrDefault().ToString();
            lblMasraf.Text = masrafTutar.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_dbContext.Basvuru.Where(s=>s.SaticiAdSoyad==txtName.Text).Select(s => s.SaticiAdSoyad).FirstOrDefault()!=null)
            {
                var odemeDurum = _dbContext.Basvuru.SingleOrDefault(s => s.OdemeDurum==false||s.OdemeDurum==null);
                odemeDurum.OdemeDurum = true;
                _dbContext.Basvuru.Update(odemeDurum);
                var aliciBasvuruTarih = _dbContext.Basvuru.Where(s => s.ReferansKod == _referans).SingleOrDefault();
                aliciBasvuruTarih.AliciBasvuruTarih = DateTime.Now;
                _dbContext.Basvuru.Update(aliciBasvuruTarih);
                var masraf = _dbContext.Basvuru.Where(s => s.ReferansKod == _referans).FirstOrDefault();
                masraf.Masraf = masrafTutar;
                _dbContext.Basvuru.Update(masraf);
                var banka = _dbContext.Basvuru.Where(s => s.ReferansKod == _referans).FirstOrDefault();
                banka.OdemeBanka_Id = (int)cmbBanka.SelectedValue;
                _dbContext.Basvuru.Update(banka);
                _dbContext.SaveChanges();
                MessageBox.Show("Ödeme ve başvuru tamamlandı.");
                Close();
            }
        }
    }
}
