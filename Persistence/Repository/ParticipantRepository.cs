using System.Data.Entity.Infrastructure.Pluralization;
using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class ParticipantRepository : Repository<Participant>
    {
        public ParticipantRepository(IDatabaseContextFactory dbContextFactory, IPluralizationService pluralizationService) : base(dbContextFactory, pluralizationService)
        {
        }
    }
}