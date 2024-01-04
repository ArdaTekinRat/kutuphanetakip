namespace KutuphaneTakip.Models
{
    public class Kutuphane
    {
        public int Id { get; set; }
        public string KutuphaneAdi { get; set; }
        public virtual List<Departmanlar> Departmanlars { get; set; }
        public virtual List<Kitaplar> Kitaplars { get; set; }
        public virtual List<Odalar> Odalars { get; set; }
        public virtual List<OduncVerilenAyar> OduncVerilenAyars { get; set; }
        public virtual List<Rezervasyon> Rezervasyons{ get; set; }





    }
}
