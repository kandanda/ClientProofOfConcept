using System.Data.Entity;

namespace Persistence
{
    public interface IDatabaseContextFactory
    {
        DbContext Create();
    }
}
