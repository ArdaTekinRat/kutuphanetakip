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
    }
}
