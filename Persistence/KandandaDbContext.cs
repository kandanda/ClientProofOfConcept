using System.Data.Entity;
using Persistence.Domain;

namespace Persistence
{
    public class KandandaDbContext : DbContext
    {
        public KandandaDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<KandandaDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<KandandaDbContext>());
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }
    }
}