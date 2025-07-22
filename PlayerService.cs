using System.Collections.Generic;
using System.Linq;

namespace Hoops.Data
{
    public class PlayerService
    {
        private List<Player> _players = new()
        {
            new Player {
                Id = 1,
                Name = "Muhammad Saad Khan",
                Age = 24,
                Position = Position.PG,
                Nationality = "USA",
                MatchStats = new MatchPerformanceStats { PlayerId = 1, Points = 22, Assists = 5, Rebounds = 3 },
                FitnessStats = new FitnessStats { MinutesPlayed = 35, SprintCount = 75 },
                InjuryHistory = new InjuryHistory { GamesMissed = 2, InjuryTypes = new List<string> { "Hamstring" } }
            },
            new Player {
                Id = 2,
                Name = "Tania Khawar",
                Age = 23,
                Position = Position.SG,
                Nationality = "Canada",
                MatchStats = new MatchPerformanceStats { PlayerId = 2, Points = 18, Assists = 7, Rebounds = 2 },
                FitnessStats = new FitnessStats { MinutesPlayed = 32, SprintCount = 68 },
                InjuryHistory = new InjuryHistory { GamesMissed = 0, InjuryTypes = new List<string>() }
            },
            new Player {
                Id = 3,
                Name = "Maaz Zulfiqar",
                Age = 26,
                Position = Position.PF,
                Nationality = "Pakistan",
                MatchStats = new MatchPerformanceStats { PlayerId = 3, Points = 15, Assists = 2, Rebounds = 12 },
                FitnessStats = new FitnessStats { MinutesPlayed = 28, SprintCount = 45 },
                InjuryHistory = new InjuryHistory { GamesMissed = 5, InjuryTypes = new List<string> { "Ankle", "Knee" } }
            },
            new Player {
                Id = 4,
                Name = "Ayesha Mudassar",
                Age = 22,
                Position = Position.SF,
                Nationality = "UAE",
                MatchStats = new MatchPerformanceStats { PlayerId = 4, Points = 17, Assists = 4, Rebounds = 6 },
                FitnessStats = new FitnessStats { MinutesPlayed = 30, SprintCount = 63 },
                InjuryHistory = new InjuryHistory { GamesMissed = 1, InjuryTypes = new List<string> { "Wrist" } }
            },
            new Player {
                Id = 5,
                Name = "Kashmala Asad",
                Age = 25,
                Position = Position.C,
                Nationality = "Australia",
                MatchStats = new MatchPerformanceStats { PlayerId = 5, Points = 14, Assists = 1, Rebounds = 15 },
                FitnessStats = new FitnessStats { MinutesPlayed = 29, SprintCount = 41 },
                InjuryHistory = new InjuryHistory { GamesMissed = 3, InjuryTypes = new List<string> { "Back", "Shoulder" } }
            }
        };

        public IEnumerable<Player> GetAllPlayers() => _players;

        public Player? GetPlayerById(int id) => _players.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Player> GetPlayersByPosition(Position position) =>
            _players.Where(p => p.Position == position);
    }
}