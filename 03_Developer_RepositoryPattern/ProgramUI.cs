using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Developer_RepositoryPattern
{
    public class ProgramUI
    {
        private TeamRepository _teamRepo = new TeamRepository();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Create new Dev Team\n" +
                    "2. View Current Dev Teams\n" +
                    "3. Get Total Dev Count\n" +
                    "4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateTeam();
                        break;
                    case 2:
                        DisplayTeams();
                        break;
                    case 3:
                        GetDevCount();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void CreateTeam()
        {
            Team newTeam = new Team();
            Console.WriteLine("Enter new team name: ");
            newTeam.TeamName = Console.ReadLine();

            List<Developer> members = new List<Developer>();
            bool creating = true;
            while (creating)
            {
                Developer newDev = new Developer();
                Console.WriteLine("Enter new developer ID: ");
                newDev.ID = Console.ReadLine();

                Console.WriteLine("Enter new developer last name: ");
                newDev.LastName = Console.ReadLine();

                Console.WriteLine("Does this developer have PluralSight? (Y/N)");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "y":
                        newDev.HasPluralSight = true;
                        break;
                    default:
                    case "n":
                        newDev.HasPluralSight = false;
                        break;
                }

                members.Add(newDev);

                Console.WriteLine("Enter another developer? (Y/N)");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "y":
                        creating = true;
                        break;
                    default:
                    case "n":
                        creating = false;
                        break;
                }
            }
            newTeam.TeamMembers = members;
        }

        private void DisplayTeams()
        {
            List<Team> devTeams = _teamRepo.GetTeams();
            foreach (Team team in devTeams)
            {
                Console.WriteLine($"Team {team.TeamName}:\n" +
                    $"Members:");
                foreach (Developer dev in team.TeamMembers)
                {
                    Console.WriteLine($"{dev.ID}. {dev.LastName}, Has PluralSight: {dev.HasPluralSight}");
                }
            }
        }

        private void GetDevCount()
        {
            int devCount = _teamRepo.GetAllDevelopersCount();
            Console.WriteLine($"The company currently has {devCount} developers across all teams.");
            Console.ReadLine();
        }
    }
}
