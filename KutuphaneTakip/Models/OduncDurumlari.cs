namespace KutuphaneTakip.Models
{
    public class OduncDurumlari
    {
        public int Id { get; set; }
       
        public string Durum { get; set; }


        public virtual List<OduncVerilenKitaplar> OduncVerilenKitaplars { get; set; }


    }
}
