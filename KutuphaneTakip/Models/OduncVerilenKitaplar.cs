namespace KutuphaneTakip.Models
{
    public class OduncVerilenKitaplar
    {
        public int Id { get; set; }
        public int KıtapId { get; set; }
        public virtual Kitaplar? Kitaplar { get; set; }

        public int DurumId { get; set; }
        public virtual OduncDurumlari? OduncDurumlari { get; set; }

        public int KullaniciId { get; set; }
        public virtual Kullanici? Kullanici { get; set; }

        public int KalanZaman { get; set; }
        public string KitapAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public int AlindigiTarih { get; set; }
        public int VerilecegiTarih { get; set; }
        public bool Guvenlik { get; set; }
        public string Cezasi { get; set; }



    }
}
