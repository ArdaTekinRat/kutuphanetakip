namespace KutuphaneTakip.Models
{
    public class KitapTurleri
    {
        public int Id { get; set; }
        public string Turler { get; set; }
        public virtual List<Kitaplar> Kitaplars { get; set; }



    }
}
