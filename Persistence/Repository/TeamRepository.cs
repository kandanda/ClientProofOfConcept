namespace Persistence.Repository
{
    public sealed class TeamRepository : Repository<Team>
    {
        public TeamRepository() : base("Teams")
        {
        }
    }
}
