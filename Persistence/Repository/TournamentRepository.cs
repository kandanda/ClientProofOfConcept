using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class TournamentRepository : Repository<Tournament>
    {
        public TournamentRepository() : base("Tournaments")
        {
        }
    }
}
