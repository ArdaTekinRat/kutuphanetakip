namespace KutuphaneTakip.Models
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public int KutuphaneId { get; set; }
        public int KullaniciId { get; set; }
        public string Kullanici { get; set; }
        public string Gmail { get; set; }
        public int Telefon { get; set; }
        public int Gun { get; set; }
        public int Saat { get; set; }
        public int Masa { get; set; }
        public int Oda { get; set; }



    }
}
