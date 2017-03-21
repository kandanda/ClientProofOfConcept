using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Pluralization;
using Persistence.Domain;
using Persistence.Repository;

namespace Persistence
{
    public sealed class Program
    {
        private static void Main()
        {
            var dbContextFactory = new KandandaDatabaseContextFactory();
            var pluralizationService = new EnglishPluralizationService();

            var tournamentRepository = new TournamentRepository(dbContextFactory, pluralizationService);
            var participantRepository = new ParticipantRepository(dbContextFactory, pluralizationService);
            
            var newTournament = new Tournament
            {
                Name = "Schweizermeisterschaft"
            };

            var newParticipant = new Participant
            {
                Name = "FC St. Gallen"
            };

            newTournament.Participants.Add(newParticipant);
            tournamentRepository.Save(newTournament);

            List<Participant> participants = participantRepository.GetAll();

            foreach (Participant participant in participants)
            {
                Console.WriteLine($"{participant.Id} {participant.Name}");
            }

            Console.ReadKey();
        }
    }
}

