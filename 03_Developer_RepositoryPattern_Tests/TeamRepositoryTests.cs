using System;
using System.Collections.Generic;
using _03_Developer_RepositoryPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Developer_RepositoryPattern_Tests
{
    [TestClass]
    public class TeamRepositoryTests
    {
        private TeamRepository _teamRepo;

        [TestMethod]
        public void TeamRepository_GetTeamCount_ReturnsCorrectCount()
        {
            // Arrange
            Team newTeam = new Team();
            _teamRepo = new TeamRepository();

            // Act
            _teamRepo.AddTeamToList(newTeam);

            int expected = 1;
            int actual = _teamRepo.GetTeamCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TeamRepo_GetTeams_ShouldReturnCorrectList()
        {
            // Arrange
            _teamRepo = new TeamRepository();
            Team teamOne = new Team();

            // Act
            _teamRepo.AddTeamToList(teamOne);
            List<Team> teamList = _teamRepo.GetTeams();

            bool expected = true;
            bool actual = teamList.Contains(teamOne);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TeamRepo_GetDevCount_ShouldReturnCorrectInt()
        {
            // Arrange
            _teamRepo = new TeamRepository();
            Developer devOne = new Developer("1a", "Tucker", true);
            Developer devTwo = new Developer("3c", "Wagner", true);
            Developer devThree = new Developer("2b", "NotToBe", false);

            List<Developer> netDevs = new List<Developer>();
            netDevs.Add(devOne);
            netDevs.Add(devTwo);

            Team dotNet = new Team(".NET", netDevs);

            List<Developer> listTwo = new List<Developer>();
            listTwo.Add(devThree);

            Team references = new Team("Hamlet", listTwo);

            _teamRepo.AddTeamToList(dotNet);
            _teamRepo.AddTeamToList(references);

            // Act
            int expected = 3;
            int actual = _teamRepo.GetAllDevelopersCount();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
