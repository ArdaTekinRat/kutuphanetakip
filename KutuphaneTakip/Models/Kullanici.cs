namespace KutuphaneTakip.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public int AdresId { get; set; }
        public virtual Adres? Adres { get; set; }
        public string Gmail { get; set; }
        public int Telefon { get; set; }
        public int ErisebilirlikId { get; set; }
        public virtual Erisebilirlik? Erisebilirlik { get; set; }
        public int DepartmanId { get; set; }
        public virtual Departmanlar? Departmanlar { get; set; }

        public int KullaniciTipiId { get; set; }
        public virtual KullaniciTipi? KullaniciTipi { get; set; }



        public virtual List<GeriBildirim> Geribildirims { get; set; }
        public virtual List<OduncVerilenKitaplar> OduncVerilenKitaplars { get; set; }
        public virtual List<Rezervasyon> Rezervasyons { get; set; }
        








    }
}
