using System;
using Persistence.Domain;
using Persistence.Repository;

namespace Persistence
{
    public sealed class Program
    {
        private static void Main()
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

            Team readTeam = teamRepository.GetEntryById(1);

            Console.WriteLine(readTeam.Id + ", " + readTeam.Name);
        }
    }
}
