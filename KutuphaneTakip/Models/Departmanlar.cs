namespace KutuphaneTakip.Models
{
    public class Departmanlar
    {
        public int Id { get; set; }
        public int KutuphaneId { get; set; }

        public virtual Kutuphane? Kutuphane { get; set; }

        public string Departman { get; set; }
        
        public virtual List<Kullanici> Kullanicis { get; set; }





    }
}
