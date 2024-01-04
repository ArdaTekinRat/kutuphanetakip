namespace KutuphaneTakip.Models
{
    public class KullaniciTipi
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        
        public virtual List<Kullanici> Kullanicis { get; set; }





    }
}
