namespace KutuphaneTakip.Models
{
    public class Yayinevi
    {
        public int Id { get; set; }
       public string YayineviAdi { get; set; }
        public virtual List<Kitaplar> Kitaplars { get; set; }



    }
}
