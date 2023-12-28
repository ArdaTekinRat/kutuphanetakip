namespace KutuphaneTakip.Models
{
    public class Kitaplar
    {
        public int Id { get; set; }
        public int KutuphaneId { get; set; }
        public string KitapAdi { get; set; }
        public int KitapTuruId { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimTarihi { get; set; }
        public int DilId { get; set; }
        public int YazarId { get; set; }

        public int YayinEviId { get; set; }
        public int KitapNo { get; set; }
        public int RafNo { get; set; }
        public int Stok { get; set; }
        public bool Guvenligi { get; set; }
        public int QRKod { get; set; }
        public int ErisebilirlikId { get; set; }
        public int GelisTarihi { get; set; }





    }
}
