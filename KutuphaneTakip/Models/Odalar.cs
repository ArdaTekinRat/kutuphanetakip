namespace KutuphaneTakip.Models
{
    public class Odalar
    {
        public int Id { get; set; }
        public int KutuphaneId { get; set; }
        public virtual Kutuphane? Kutuphane { get; set; }

        public int OdatipId { get; set; }

        public virtual OdaTipi? OdaTipi { get; set; }


        public string OdaAdi { get; set; }
        



    }
}
