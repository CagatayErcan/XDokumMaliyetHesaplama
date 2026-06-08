using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace XDokumMaliyetHesaplama
{
    public partial class Form1 : Form
    {
        // YENİ: Parça adları ile resim dosyası adlarını eşleştiren sözlük
        private Dictionary<string, string> parcaResimDict = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açılırken parçaları listeye yükle
            ParcalariYukle();
            // YENİ: Logo'yu yükle
            LogoYukle();
            // YENİ: Parça-Resim eşleştirme sözlüğünü doldur
            ParcaResimEsleme();
        }
        private void ParcaResimEsleme()
        {
            parcaResimDict.Add("Döküm Flanş", "dokumflans.png");
            parcaResimDict.Add("Sfero Gövde", "sferogovde.png");
            parcaResimDict.Add("Fren Diski", "frendiski.png");
            parcaResimDict.Add("Pompa Gövdesi", "pompagovdesi.png");
        }

        private void LogoYukle()
        {
            string dosyaYolu = Application.StartupPath + "\\Images\\lotus.png";
            if (System.IO.File.Exists(dosyaYolu))
            {
                picLogo.Image = System.Drawing.Image.FromFile(dosyaYolu);
            }
            else
            {
                // Dosya bulunamazsa hata mesajı gösterme, sadece arka planı gri yap
                picLogo.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void ParcalariYukle()
        {
            try
            {
                DataTable dt = DBHelper.GetParcalar();
                cmbParcalar.DisplayMember = "ParcaAdi";  // Kullanıcıya görünecek sütun
                cmbParcalar.ValueMember = "ParcaID";     // Arkada tutulacak değer
                cmbParcalar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Seçilen parçanın resmini göster (zaten seçim değişince gösteriyor ama garanti olsun)
            if (cmbParcalar.SelectedItem != null)
            {
                ParcaResminiGoster(cmbParcalar.Text);
            }
            if (cmbParcalar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir parça seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int secilenParcaID = (int)cmbParcalar.SelectedValue;
                DataTable dt = DBHelper.GetMaliyetDetay(secilenParcaID);

                // Toplam maliyeti hesapla
                decimal toplamUSD = 0;
                foreach (DataRow row in dt.Rows)
                {
                    toplamUSD += Convert.ToDecimal(row["Tutar_USD"]);
                }

                lblToplamMaliyet.Text = $"Toplam Maliyet: {toplamUSD:N2} USD";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKirilim_Click(object sender, EventArgs e)
        {
            if (cmbParcalar.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir parça seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int secilenParcaID = (int)cmbParcalar.SelectedValue;
                DataTable dt = DBHelper.GetMaliyetDetay(secilenParcaID);
                dgvDetay.DataSource = dt;

                // DataGridView sütun başlıklarını Türkçeleştir
                if (dgvDetay.Columns["KalemAdi"] != null) dgvDetay.Columns["KalemAdi"].HeaderText = "Maliyet Kalemi";
                if (dgvDetay.Columns["Birim"] != null) dgvDetay.Columns["Birim"].HeaderText = "Birim";
                if (dgvDetay.Columns["BirimTuketim"] != null) dgvDetay.Columns["BirimTuketim"].HeaderText = "Birim Tüketim";
                if (dgvDetay.Columns["BirimMaliyet_USD"] != null) dgvDetay.Columns["BirimMaliyet_USD"].HeaderText = "Birim Maliyet (USD)";
                if (dgvDetay.Columns["Tutar_USD"] != null) dgvDetay.Columns["Tutar_USD"].HeaderText = "Tutar (USD)";
                if (dgvDetay.Columns["Aciklama"] != null) dgvDetay.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detaylar getirilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ParcaResminiGoster(string parcaAdi)
        {
            if (parcaResimDict.ContainsKey(parcaAdi))
            {
                string resimDosyasi = parcaResimDict[parcaAdi];
                string dosyaYolu = Application.StartupPath + "\\Images\\" + resimDosyasi;

                if (System.IO.File.Exists(dosyaYolu))
                {
                    picParcaResmi.Image = System.Drawing.Image.FromFile(dosyaYolu);
                }
                else
                {
                    // Resim bulunamazsa boş göster
                    picParcaResmi.Image = null;
                    picParcaResmi.BackColor = System.Drawing.Color.LightGray;
                }
            }
            else
            {
                // Eşleşme yoksa resmi temizle
                picParcaResmi.Image = null;
                picParcaResmi.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void cmbParcalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen parçanın adını al
            if (cmbParcalar.SelectedItem != null)
            {
                string secilenParcaAdi = cmbParcalar.Text;
                ParcaResminiGoster(secilenParcaAdi);
            }
        }
    }
}