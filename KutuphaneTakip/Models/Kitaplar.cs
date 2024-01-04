namespace KutuphaneTakip.Models
{
    public class Kitaplar
    {
        public int Id { get; set; }
        public int KutuphaneId { get; set; }
        public virtual Kutuphane? Kutuphane { get; set; }

        public string KitapAdi { get; set; }
        public int KitapTuruId { get; set; }
        public virtual KitapTurleri? KitapTurleri { get; set; }

        public int SayfaSayisi { get; set; }
        public int BasimTarihi { get; set; }
        public int DilId { get; set; }
        public virtual DilTurleri? DilTurleri { get; set; }

        public int YazarId { get; set; }
        public virtual Yazar? Yazar { get; set; }

        public int YayinEviId { get; set; }
        public virtual Yayinevi? Yayinevi { get; set; }

        public int KitapNo { get; set; }
        public int RafNo { get; set; }
        public int Stok { get; set; }
        public bool Guvenligi { get; set; }
        public int QRKod { get; set; }
        public int ErisebilirlikId { get; set; }
        public virtual Erisebilirlik? Erisebilirlik { get; set; }

        public int GelisTarihi { get; set; }



        public virtual List<OduncVerilenKitaplar> OduncVerilenKitaplars { get; set; }


    }
}
