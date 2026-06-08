using System;
using System.Windows.Forms;

namespace XDokumMaliyetHesaplama
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Önce server seçim formunu göster
            frmServerSecim serverSecim = new frmServerSecim();
            serverSecim.ShowDialog();

            // Eğer kullanıcı geçerli bir seçim yaptıysa ve bağlantı ayarları varsa ana formu aç
            if (!string.IsNullOrEmpty(BaglantiAyarlari.ServerAdresi))
            {
                Application.Run(new Form1());
            }
        }
    }
}