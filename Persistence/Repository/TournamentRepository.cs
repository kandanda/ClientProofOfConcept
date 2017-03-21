using System.Data.Entity.Infrastructure.Pluralization;
using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class TournamentRepository : Repository<Tournament>
    {
        public TournamentRepository(IDatabaseContextFactory dbContextFactory, IPluralizationService pluralizationService) : base(dbContextFactory, pluralizationService)
        {
        }
    }
}