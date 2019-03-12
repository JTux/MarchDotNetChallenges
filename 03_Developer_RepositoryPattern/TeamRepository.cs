using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Developer_RepositoryPattern
{
    public class TeamRepository
    {
        private List<Team> _teamList = new List<Team>();

        public void AddTeamToList(Team team)
        {
            _teamList.Add(team);
        }

        public List<Team> GetTeams()
        {
            return _teamList;
        }

        public int GetTeamCount()
        {
            int teamCount = _teamList.Count;
            return teamCount;
        }

        public int GetAllDevelopersCount()
        {
            int totalCount = 0;
            foreach(Team team in _teamList)
            {
                totalCount += team.TeamMembers.Count;
            }
            return totalCount;
        }
    }
}
