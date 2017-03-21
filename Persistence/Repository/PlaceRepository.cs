using System.Data.Entity.Infrastructure.Pluralization;
using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class PlaceRepository : Repository<Place>
    {
        public PlaceRepository(IDatabaseContextFactory dbContextFactory, IPluralizationService pluralizationService) : base(dbContextFactory, pluralizationService)
        {
        }
    }
}