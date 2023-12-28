namespace KutuphaneTakip.Models
{
    public class OduncVerilenKitaplar
    {
        public int Id { get; set; }
        public int KıtapId { get; set; }
        public int DurumId { get; set; }
        public int KullaniciId { get; set; }
        public int KalanZaman { get; set; }
        public string KitapAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public int AlindigiTarih { get; set; }
        public int VerilecegiTarih { get; set; }
        public bool Guvenlik { get; set; }
        public string Cezasi { get; set; }



    }
}
