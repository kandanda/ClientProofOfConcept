using System.Data.Entity;

namespace Persistence
{
    public sealed class KandandaDatabaseContextFactory : IDatabaseContextFactory
    {
        public DbContext Create()
        {
            return new KandandaDbContext();
        }
    }
}
