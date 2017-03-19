using System;
using Persistence.Repository;

namespace Persistence
{
    public sealed class Program
    {
        public static void Main()
        {
            TeamRepository teamRepository = new TeamRepository();

            Team newTeam = new Team
            {
                Name = "FC Basel"
            };

            teamRepository.Save(newTeam);

            foreach (Team team in teamRepository.GetAll())
            {
                Console.WriteLine(team.Name);
            }

            Console.ReadKey(true);
        }
    }
}
