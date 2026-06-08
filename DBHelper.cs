using System.Data;
using System.Data.SqlClient;

namespace XDokumMaliyetHesaplama
{
    public static class DBHelper
    {
        private static string GetBaglantiCumlesi()
        {
            return BaglantiAyarlari.GetBaglantiCumlesi();
        }

        public static DataTable GetParcalar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection baglanti = new SqlConnection(GetBaglantiCumlesi()))
            {
                string sorgu = "SELECT ParcaID, ParcaAdi FROM Parcalar WHERE Aktif = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                adapter.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetMaliyetDetay(int parcaID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection baglanti = new SqlConnection(GetBaglantiCumlesi()))
            {
                string sorgu = @"SELECT mk.KalemAdi, mk.Birim, pmd.BirimTuketim, pmd.BirimMaliyet_USD, 
                                        (pmd.BirimTuketim * pmd.BirimMaliyet_USD) AS Tutar_USD, pmd.Aciklama
                                 FROM ParcaMaliyetDetay pmd
                                 JOIN MaliyetKalemleri mk ON pmd.KalemID = mk.KalemID
                                 WHERE pmd.ParcaID = @parcaID";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                adapter.SelectCommand.Parameters.AddWithValue("@parcaID", parcaID);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}