using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class TeamRepository : Repository<Participant>
    {
        public TeamRepository() : base("Teams")
        {
        }
    }
}
