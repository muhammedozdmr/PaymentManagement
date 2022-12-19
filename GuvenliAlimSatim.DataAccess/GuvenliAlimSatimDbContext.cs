using GuvenliAlımSatım;
using Microsoft.EntityFrameworkCore;

namespace GuvenliAlimSatim.DataAccess
{
    public class GuvenliAlimSatimDbContext : DbContext
    {
        public DbSet<Basvuru> Basvuru { get; set; }
        public DbSet<Bankalar> Bankalar { get; set; }
        public DbSet<GercekTuzel> GercekTuzel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=GuvenliAlimSatim;Integrated Security=true");
        }
    }
}