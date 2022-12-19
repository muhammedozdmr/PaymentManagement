namespace GuvenliAlimSatim.UI.Main
{
    public partial class BasvuruDetayForm : Form
    {
        private readonly string _referans;
        private readonly string _basvuruDurum;
        private readonly string _odemeDurum;

        public BasvuruDetayForm(string referans,string basvuruDurum,string odemeDurum)
        {
            InitializeComponent();
            this._referans = referans;
            this._basvuruDurum = basvuruDurum;
            this._odemeDurum = odemeDurum;
        }

        private void BasvuruDetayForm_Load(object sender, EventArgs e)
        {
            lblReferansNo.Text = _referans;
            lblBasvuruDurum.Text = _basvuruDurum;
            lblOdemeDurum.Text = _odemeDurum;
        }
    }
}
