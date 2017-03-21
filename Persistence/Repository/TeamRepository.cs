using System.Data.Entity.Infrastructure.Pluralization;
using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class TeamRepository : Repository<Participant>
    {
        public TeamRepository(IDatabaseContextFactory dbContextFactory, IPluralizationService pluralizationService) : base(dbContextFactory, pluralizationService)
        {
        }
    }
}
