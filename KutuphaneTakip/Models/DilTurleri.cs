namespace KutuphaneTakip.Models
{
    public class DilTurleri
    {
        public int Id { get; set; }
        public string Dil {  get; set; }
        public virtual List<Kitaplar> Kitaplars { get; set; }




    }
}
