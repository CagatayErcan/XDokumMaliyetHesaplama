namespace XDokumMaliyetHesaplama
{
    public static class BaglantiAyarlari
    {
        public static string ServerAdresi { get; set; }
        public static string VeritabaniAdi { get; set; }

        public static string GetBaglantiCumlesi()
        {
            return $"Data Source={ServerAdresi};Initial Catalog={VeritabaniAdi};Integrated Security=True;TrustServerCertificate=True";
        }
    }
}