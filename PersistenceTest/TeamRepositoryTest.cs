using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence.Domain;
using Persistence.Repository;

namespace PersistenceTest
{
    [TestClass]
    public class TeamRepositoryTest
    {
        [TestMethod]
        public void TestCreateNewTeam()
        {
            string teamName = "FC St. Gallen";
            Participant newTeam = CreateTeam(teamName);

            int id = newTeam.Id;

            Participant reloadedTeam = GetEntryById(id);

            Assert.AreEqual(teamName, reloadedTeam.Name);
            Assert.AreEqual(id, reloadedTeam.Id);
        }

        [TestMethod]
        public void TestDeleteAllTeam()
        {
            DeleteAll();

            int teamCount = GetAll().Count;

            Assert.AreEqual(0, teamCount);

            CreateTeam("FC Basel");
            CreateTeam("FC Zug");

            teamCount = GetAll().Count;

            Assert.AreEqual(2, teamCount);
        }
        
        private List<Participant> GetAll()
        {
            TeamRepository repository = new TeamRepository();
            return repository.GetAll();
        }

        private void DeleteAll()
        {
            TeamRepository repository = new TeamRepository();
            repository.DeleteAll();
        }

        private Participant GetEntryById(int id)
        {
            TeamRepository repository = new TeamRepository();
            Participant team = repository.GetEntryById(id);
            return team;
        }

        private Participant CreateTeam(string teamName)
        {
            Participant newTeam = new Participant
            {
                Name = teamName
            };

            TeamRepository repository = new TeamRepository();
            repository.Save(newTeam);

            return newTeam;
        }
    }
}
