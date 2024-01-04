namespace KutuphaneTakip.Models
{
    public class OdaTipi
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public virtual List<Odalar> Odalars { get; set; }





    }
}
