using System.Data.Entity.Infrastructure.Pluralization;
using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class PhaseRepository : Repository<Phase>
    {
        public PhaseRepository(IDatabaseContextFactory dbContextFactory, IPluralizationService pluralizationService) : base(dbContextFactory, pluralizationService)
        {
        }
    }
}
