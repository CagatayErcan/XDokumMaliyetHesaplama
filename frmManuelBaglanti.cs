using System;
using System.Windows.Forms;

namespace XDokumMaliyetHesaplama
{
    public partial class frmManuelBaglanti : Form
    {
        // Dışarıdan erişilebilir özellikler
        public string ServerAdresi { get; private set; }
        public string VeritabaniAdi { get; private set; }

        public frmManuelBaglanti()
        {
            InitializeComponent();
        }

        private void frmManuelBaglanti_Load(object sender, EventArgs e)
        {
            // Varsayılan değerler
            txtServer.Text = "";
            txtDatabase.Text = "XDokumMaliyet";
        }

        // Tamam Butonu
        private void btnTamam_Click(object sender, EventArgs e)
        {
            // Server adresi kontrolü
            if (string.IsNullOrWhiteSpace(txtServer.Text))
            {
                MessageBox.Show("Lütfen SQL Server adresini giriniz.\n\nÖrnek formatlar:\nlocalhost\\SQLEXPRESS\n192.168.1.100\\MSSQLSERVER\nSIRKET-SERVERI",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı adı kontrolü
            if (string.IsNullOrWhiteSpace(txtDatabase.Text))
            {
                MessageBox.Show("Lütfen veritabanı adını giriniz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Değerleri kaydet
            ServerAdresi = txtServer.Text.Trim();
            VeritabaniAdi = txtDatabase.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // İptal Butonu
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}