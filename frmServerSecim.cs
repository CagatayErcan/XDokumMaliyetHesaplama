using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace XDokumMaliyetHesaplama
{
    public partial class frmServerSecim : Form
    {
        // Manuel giriş için değişkenler
        private string manuelServerAdresi = "";
        private string manuelVeritabani = "XDokumMaliyet";

        public frmServerSecim()
        {
            InitializeComponent();
        }

        private void frmServerSecim_Load(object sender, EventArgs e)
        {
            // Logo yükle
            string logoYolu = Application.StartupPath + "\\Images\\lotus.png";
            if (System.IO.File.Exists(logoYolu))
            {
                picLogo.Image = System.Drawing.Image.FromFile(logoYolu);
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            // ComboBox seçeneklerini doldur
            cmbServerSecim.Items.Clear();
            cmbServerSecim.Items.Add("Şirket Serverı (Varsayılan)");
            cmbServerSecim.Items.Add("Localhost (Geliştirme)");
            cmbServerSecim.Items.Add("Diğer (Manuel Giriş)");

            // Varsayılan seçim: Şirket Serverı
            cmbServerSecim.SelectedIndex = 0;

            // Durum etiketini temizle
            lblDurum.Text = "";
        }

        // Seçime göre server adresini döndürür
        private string GetServerAdresi()
        {
            if (cmbServerSecim.SelectedItem == null)
                return @"localhost\SQLEXPRESS";

            string secim = cmbServerSecim.SelectedItem.ToString();

            switch (secim)
            {
                case "Şirket Serverı (Varsayılan)":
                    // 🔧 DEVREYE ALINCA BURAYI GÜNCELLE!
                    // Örnek formatlar:
                    // return @"192.168.1.100\SQLEXPRESS";
                    // return @"CORP-SQL-01\INSTANCE";
                    // return @"10.10.10.50\MSSQLSERVER";
                    return @"SIRKET_SERVERI\SQLEXPRESS";  // <-- BURAYI DEĞİŞTİR

                case "Localhost (Geliştirme)":
                    return @"localhost\SQLEXPRESS";

                case "Diğer (Manuel Giriş)":
                    return manuelServerAdresi;

                default:
                    return @"localhost\SQLEXPRESS";
            }
        }

        // Veritabanı adını döndürür
        private string GetVeritabaniAdi()
        {
            if (cmbServerSecim.SelectedItem == null)
                return "XDokumMaliyet";

            string secim = cmbServerSecim.SelectedItem.ToString();

            if (secim == "Diğer (Manuel Giriş)")
                return manuelVeritabani;
            else
                return "XDokumMaliyet";
        }

        // ComboBox seçimi değiştiğinde
        private void cmbServerSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServerSecim.SelectedItem != null &&
                cmbServerSecim.SelectedItem.ToString() == "Diğer (Manuel Giriş)")
            {
                using (frmManuelBaglanti manuelForm = new frmManuelBaglanti())
                {
                    if (manuelForm.ShowDialog() == DialogResult.OK)
                    {
                        manuelServerAdresi = manuelForm.ServerAdresi;
                        manuelVeritabani = manuelForm.VeritabaniAdi;
                        lblDurum.Text = $"Manuel server: {manuelServerAdresi}";
                        lblDurum.ForeColor = Color.Green;
                    }
                    else
                    {
                        // İptal edilirse varsayılana dön
                        cmbServerSecim.SelectedIndex = 0;
                        lblDurum.Text = "";
                    }
                }
            }
        }

        // Bağlantı Testi Butonu
        private void btnTestBaglanti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton çalışıyor!");  // <-- BU SATIRI EKLE
            string serverAdresi = GetServerAdresi();
            string veritabaniAdi = GetVeritabaniAdi();

            if (string.IsNullOrEmpty(serverAdresi))
            {
                lblDurum.Text = "✗ Lütfen geçerli bir server adresi girin!";
                lblDurum.ForeColor = Color.Red;
                return;
            }

            string testBaglanti = $"Data Source={serverAdresi};Initial Catalog={veritabaniAdi};Integrated Security=True;TrustServerCertificate=True;Connection Timeout=5";

            using (SqlConnection baglanti = new SqlConnection(testBaglanti))
            {
                try
                {
                    baglanti.Open();
                    lblDurum.Text = "✓ Bağlantı başarılı!";
                    lblDurum.ForeColor = Color.Green;
                    MessageBox.Show($"Veritabanına başarıyla bağlanıldı!\n\nServer: {serverAdresi}\nVeritabanı: {veritabaniAdi}",
                                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string hataMesaji = ex.Message.Split('.')[0];
                    lblDurum.Text = $"✗ Bağlantı hatası: {hataMesaji}";
                    lblDurum.ForeColor = Color.Red;
                    MessageBox.Show($"Bağlantı hatası:\n{ex.Message}",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Devam Et Butonu - Seçimi kaydedip ana forma geçer
        private void btnDevam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Devam butonuna tıklandı!");  // <-- BUNU EKLEYİN
            string serverAdresi = GetServerAdresi();
            string veritabaniAdi = GetVeritabaniAdi();

            if (string.IsNullOrEmpty(serverAdresi))
            {
                lblDurum.Text = "✗ Lütfen geçerli bir server adresi seçin veya girin!";
                lblDurum.ForeColor = Color.Red;
                return;
            }

            // Seçimi global ayarlara kaydet
            BaglantiAyarlari.ServerAdresi = serverAdresi;
            BaglantiAyarlari.VeritabaniAdi = veritabaniAdi;

            // Ana formu aç
            this.Hide();
            Form1 anaForm = new Form1();
            anaForm.ShowDialog();
            this.Close();
        }
    }
}