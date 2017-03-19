using System;
using System.Collections.Generic;
using Persistence.Domain;
using Persistence.Repository;

namespace Persistence
{
    public sealed class Program
    {
        private static void Main()
        {
            TournamentRepository tournamentRepo = new TournamentRepository();
            ParticipantRepository participantRepo = new ParticipantRepository();

            Tournament newTournament = new Tournament
            {
                Name = "Schweizermeisterschaft"
            };

            Participant newParticipant = new Participant
            {
                Name = "FC St. Gallen"
            };

            newTournament.Participants.Add(newParticipant);

            tournamentRepo.Save(newTournament);

            List<Participant> participants = participantRepo.GetAll();

            foreach (Participant participant in participants)
            {
                Console.WriteLine($"{participant.Id} {participant.Name}");
            }

            Console.ReadKey();
        }
    }
}

