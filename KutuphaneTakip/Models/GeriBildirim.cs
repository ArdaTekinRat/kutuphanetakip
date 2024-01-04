namespace KutuphaneTakip.Models
{
    public class GeriBildirim
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici? Kullanici { get; set; }

        public string Gmail { get; set; }
        public int Sms { get; set; }
        public string Bildiri { get; set; }
        public int Tarih {  get; set; }



    }
}
