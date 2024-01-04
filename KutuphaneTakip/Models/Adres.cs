namespace KutuphaneTakip.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public int Bina { get; set; }
        public int Kat { get; set; }
        public virtual List<Kullanici> Kullanicis { get; set; }





    }
}
