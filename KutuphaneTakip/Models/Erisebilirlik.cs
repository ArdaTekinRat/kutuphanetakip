﻿namespace KutuphaneTakip.Models
{
    public class Erisebilirlik
    {
        public int Id { get; set; }
        public int Yetki { get; set; }
        public virtual List<Kullanici> Kullanicis { get; set; }


        public virtual List<Kitaplar> Kitaplars { get; set; }


    }
}
