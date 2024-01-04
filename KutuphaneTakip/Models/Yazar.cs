namespace KutuphaneTakip.Models
{
    public class Yazar
    {
        public int Id { get; set; }
        public string YazarAdi { get; set; }
        public virtual List<Kitaplar> Kitaplars { get; set; }



    }
}
