using System;
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
    }
}
