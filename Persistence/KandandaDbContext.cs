using System.Data.Entity;

namespace Persistence
{
    public class KandandaDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}