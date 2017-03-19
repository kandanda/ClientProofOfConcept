using Persistence.Domain;

namespace Persistence.Repository
{
    public sealed class ParticipantRepository : Repository<Participant>
    {
        public ParticipantRepository() : base("Participants")
        {
        }
    }
}
