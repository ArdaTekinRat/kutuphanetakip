using KutuphaneTakip.Models;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneTakip.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) :
        base(options)
            {
            
        }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Adres> Adress { get; set; }
        public DbSet<DilTurleri> DilTurleris { get; set; }
        public DbSet<Erisebilirlik> Erisebilirliks { get; set; }
        public DbSet<GeriBildirim> GeriBildirims { get; set; }
        public DbSet<Kitaplar> Kitaplars { get; set; }
        public DbSet<KitapTurleri> KitapTurleris { get; set; }
        public DbSet<Odalar> Odalars { get; set; }
        public DbSet<OduncDurumlari> OduncDurumlaris { get; set; }
        public DbSet<OduncVerilenAyar> OduncVerilenAyars { get; set; }
        public DbSet<OduncVerilenKitaplar> OduncVerilenKitaplars { get; set; }
        public DbSet<Rezervasyon> Rezervasyons { get; set; }
        public DbSet<Yayinevi> Yayinevis { get; set; }
        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Departmanlar> Departmanlars { get; set; }
        public DbSet<Kutuphane> Kutuphanelers { get; set; }
        public DbSet<OdaTipi> OdaTipis { get; set; }
        public DbSet<KullaniciTipi> KullaniciTipis { get; set; }

    }
}
