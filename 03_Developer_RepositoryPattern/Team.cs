using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Developer_RepositoryPattern
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Developer> TeamMembers { get; set; }

        public Team() { }
        public Team(string teamName, List<Developer> teamMembers)
        {
            TeamName = teamName;
            TeamMembers = teamMembers;
        }
    }
}
